using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    //public InputAction playerControls;
    public Apothecary playerControls;

    Vector2 moveDirection = Vector2.zero;
    private InputAction move;
    private InputAction fire;

    private void Awake()
    {
        playerControls = new Apothecary();
    }
    private void OnEnable()
    {
        //playerControls.Enable();
        move = playerControls.Player.Move;
        move.Enable();

        fire = playerControls.Player.Fire;
        fire.Enable();
        fire.performed += Interact;
    }
    private void OnDisable()
    {
        move.Disable();
        fire.Disable();
        //playerControls.Disable();
    }

    // Update is called once per frame
    void Update()//input
    {
        //Input.GetAxisRaw("Horizontal");//gives us a value between negative 1 and 1 
        //Input.GetAxisRaw("Vertical");
        //moveDirection = playerControls.ReadValue<Vector2>();
        moveDirection = move.ReadValue<Vector2>();

    }
    private void FixedUpdate()//movement
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    private void Interact(InputAction.CallbackContext context)
    {
        Debug.Log("We interacted with an object");
    }
}
