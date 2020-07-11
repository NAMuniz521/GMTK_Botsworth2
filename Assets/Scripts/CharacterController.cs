using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Transform playerTransform;
    [SerializeField] Rigidbody2D playerRB;

    [Header("Input")]
    [SerializeField] PlayerInputAction inputActions;

    [Range(0,1)]
    public float speed;
    [Range(0, 20)]
    public float jumpForce;
    [Range(0, 10)]
    public float raycastDist; //for isOnGround
    public bool isOnGround;

    //Movement
    Vector2 moveInput;



    // Start is called before the first frame update
    private void Awake()
    {
        playerTransform = GetComponent<Transform>();
        playerRB = GetComponent<Rigidbody2D>();

        inputActions = new PlayerInputAction();
        inputActions.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        
    }

    private void FixedUpdate()
    {
        Vector3 moveDir = new Vector3(moveInput.x * speed, 0, 0);
        playerTransform.position += Vector3.Lerp(Vector3.zero, moveDir, Time.deltaTime * 10f);
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CollisionIsWithGround(collision))
        {
            isOnGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (!CollisionIsWithGround(collision))
        {
            isOnGround = false;
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
