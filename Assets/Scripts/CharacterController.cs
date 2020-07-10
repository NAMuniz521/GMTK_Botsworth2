using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Transform playerTransform;

    [Header("Input")]
    [SerializeField] PlayerInputAction inputActions;

    [Range(0,1)]
    public float speed;

    //Movement
    Vector2 moveInput;



    // Start is called before the first frame update
    private void Awake()
    {
        playerTransform = GetComponent<Transform>();

        inputActions = new PlayerInputAction();
        inputActions.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        
    }

    private void FixedUpdate()
    {
        Vector3 moveDir = new Vector3(moveInput.x * speed, 0, 0);
        playerTransform.position += Vector3.Lerp(Vector3.zero, moveDir, Time.deltaTime * 10f);

      
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
