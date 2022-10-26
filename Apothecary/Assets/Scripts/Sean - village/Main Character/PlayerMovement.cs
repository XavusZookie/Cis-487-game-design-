using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Events")]
    public GameEvent onPlayerInteract;
    
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
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
        move = playerControls.Player.Move;////giving me trouble
        move.Enable();

        fire = playerControls.Player.Fire;
        fire.Enable();
        fire.performed += Interact;

    }
    private void OnDisable()
    {
        move.Disable();
        fire.Disable();
    }


    // Update is called once per frame
    void Update()//input
    {
        moveDirection = move.ReadValue<Vector2>();
        
    }
    private void FixedUpdate()//movement
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    private void Interact(InputAction.CallbackContext context)
    {
        onPlayerInteract.Raise(this,context.ReadValueAsButton());
    }
}
