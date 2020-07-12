using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Transform playerTransform;
    [SerializeField] Rigidbody2D playerRB;
    [SerializeField] Animator playerAnim;
    [SerializeField] SpriteRenderer playerRenderer;

    [Header("Input")]
    [SerializeField] PlayerInputAction inputActions;

    [Range(0,1)]
    public float speed;
    [Range(0, 20)]
    public float jumpForce;
    public bool isOnGround;

    //Movement
    public Vector2 moveInput;



    // Start is called before the first frame update
    private void Awake()
    {
        playerTransform = GetComponent<Transform>();
        playerRB = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
        playerRenderer = GetComponent<SpriteRenderer>();

        inputActions = new PlayerInputAction();
        inputActions.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        
    }

    private void FixedUpdate()
    {
        if(moveInput.x < 0)
        {
            playerRenderer.flipX = false;
        }
        else if(moveInput.x > 0)
        {
            playerRenderer.flipX = true;
        }

        Vector3 moveDir = new Vector3(moveInput.x * speed, 0, 0);
        playerAnim.SetFloat("Speed", Mathf.Abs(moveInput.x));
        playerTransform.position += Vector3.Lerp(Vector3.zero, moveDir, Time.deltaTime * 10f);
        
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
        foreach(ContactPoint2D c in collision.contacts)
        {
            Vector2 collision_direction_vector = c.point - playerRB.position;
            if(collision_direction_vector.y < 0)
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
}
