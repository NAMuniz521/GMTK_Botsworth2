using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Transform playerTransform; //populated in start()
    [SerializeField] Rigidbody2D playerRB; //populated in start()
    [SerializeField] Animator playerAnim; //populated in start()
    [SerializeField] SpriteRenderer playerRenderer; //populated in start()
    [SerializeField] GameObject shield;
    public GameObject keyPrefab;
    public GameObject keyHolder;

    [Header("Input")]
    [SerializeField] PlayerInputAction inputActions;

    [Header("Player Stats")]
    [Range(0, 1)]
    public float speed;
    [Range(0, 50)]
    public float jumpForce;
    [Range(0, 200)]
    public float maxEnergy;
    [Range(0, 10)]
    public float energyUsedPerSecond;
    [Range(0, 10)]
    public float energyGainedPerSecond;

    public float minHackTime = 5f;
    public float maxHackTime = 20f;
    Coroutine hackTimer;
    Coroutine hackCoroutine;
    public List<KeyCode> keysForHackingMinigame = new List<KeyCode>();
    public int amountKeysForHackingMinigame;
    public List<GameObject> keyObjectList = new List<GameObject>();


    private bool isOnGround;
    private Vector2 moveInput;
    private bool mouseClicked;
    [HideInInspector] public float energy;
    [HideInInspector] public bool isDead = false;
    [HideInInspector] public bool isShieldActive = false;



    // Start is called before the first frame update
    private void Awake()
    {
        playerTransform = GetComponent<Transform>();
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        playerRenderer = GetComponent<SpriteRenderer>();

        energy = maxEnergy;

        inputActions = new PlayerInputAction();
        inputActions.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        inputActions.Player.ActivateShield.started += ctx => OnMouseClick();
        inputActions.Player.ActivateShield.canceled += ctx => OnMouseReleased();
        inputActions.Player.Jump.performed += ctx => Jump();

        StartCoroutine(EnergyRecharge());
    }

    private void Update()
    {
        if (hackTimer == null)
        {
            hackTimer = StartCoroutine(HackTimer(Random.Range(minHackTime, maxHackTime)));
        }
    }

    private void FixedUpdate()
    {
        if (moveInput.x < 0)
        {
            playerRenderer.flipX = false;
        }
        else if (moveInput.x > 0)
        {
            playerRenderer.flipX = true;
        }

        Vector3 moveDir = new Vector3(moveInput.x * speed, 0, 0);
        playerAnim.SetFloat("Speed", Mathf.Abs(moveInput.x));
        if (!isDead)
        {
            playerTransform.position += Vector3.Lerp(Vector3.zero, moveDir, Time.deltaTime * 10f);
        }

    }

    IEnumerator HackTimer(float secondsToStartHack)
    {
        float startTime = Time.time;
        while (Time.time < startTime + secondsToStartHack)
        {
            //Debug.Log("Waiting for Hack: " + (startTime + secondsToStartHack - Time.time) + " seconds remain");
            // TODO: at 5 seconds remaining start beeping botsworth red
            yield return null;
        }

        if (hackCoroutine == null)
        {
            hackCoroutine = StartCoroutine(HackCoroutine());
        }

        hackTimer = null;
    }

    IEnumerator HackCoroutine()
    {
        List<KeyCode> tempKeyList = new List<KeyCode>();
        for (int i = 0; i < amountKeysForHackingMinigame; i++)
        {
            KeyCode key = keysForHackingMinigame[Random.Range(0, keysForHackingMinigame.Count)];
            tempKeyList.Add(key);
            GameObject keyObject = Instantiate(keyPrefab, keyHolder.transform);
            keyObject.GetComponentInChildren<Text>().text = key.ToString();
            keyObjectList.Add(keyObject);
        }


        for (int i = 0; i < tempKeyList.Count; i++)
        {
            while (!Input.GetKey(tempKeyList[i]))
            {
                yield return null;
            }
            Destroy(keyObjectList[i]);
        }

        hackCoroutine = null;
    }

    public void OnMouseClick()
    {
        if (energy > 0)
        {
            //Debug.Log("Shield Active");
            shield.SetActive(true);
            StartCoroutine(ShieldDecay());
            isShieldActive = true;
        }
    }

    public void OnMouseReleased()
    {
        //Debug.Log("Shield Deactive");
        shield.SetActive(false);
        StopCoroutine(ShieldDecay());
        isShieldActive = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CollisionIsWithGround(collision))
        {
            isOnGround = true;
            playerAnim.SetBool("Jumping", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!CollisionIsWithGround(collision))
        {
            isOnGround = false;
            playerAnim.SetBool("Jumping", true);
        }
    }

    public void Jump()
    {
        Debug.Log("Jump");

        if (isOnGround) //set up isOnGround bool
        {
            playerRB.AddForce(new Vector2(0, jumpForce * 10f));
        }
    }

    private bool CollisionIsWithGround(Collision2D collision)
    {
        bool is_with_ground = false;
        foreach (ContactPoint2D c in collision.contacts)
        {
            Vector2 collision_direction_vector = c.point - playerRB.position;
            if (collision_direction_vector.y < 0)
            {
                //collison happens below character
                is_with_ground = true;
            }
        }

        return is_with_ground;
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    public void Died()
    {
        isDead = true;
        playerAnim.SetBool("Dead", true);
        StopAllCoroutines();
        StartCoroutine(Respawn());
    }

    IEnumerator Respawn()
    {
        yield return new WaitForSeconds(0.3f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public IEnumerator ShieldDecay()
    {
        while (shield.activeInHierarchy == true)
        {
            if (energy > 0)
            {
                energy -= energyUsedPerSecond;
            }
            else
            {
                shield.SetActive(false);
                isShieldActive = false;
                StopCoroutine(ShieldDecay());
            }

            yield return new WaitForSeconds(1);
        }
    }

    public IEnumerator EnergyRecharge()
    {
        while (true)
        {
            if (energy < maxEnergy && shield.activeInHierarchy == false)
            {
                energy += energyGainedPerSecond;
            }
            yield return new WaitForSeconds(1);
        }
    }
}
