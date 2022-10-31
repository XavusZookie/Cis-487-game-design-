using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Events")]
    public GameEvent onPlayerInteract;
    public GameEvent on_l_click;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Apothecary playerControls;

    Vector2 moveDirection = Vector2.zero;
    private InputAction move;
    private InputAction fire;
    private InputAction ui_l_click;
    private InputAction ui_r_click;

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

        ui_l_click = playerControls.UI.Click;
        ui_l_click.Enable();
        ui_l_click.performed += l_click;

        ui_r_click = playerControls.UI.Click;
        ui_r_click.Enable();
        
    }
    private void OnDisable()
    {
        move.Disable();
        fire.Disable();
        ui_l_click.Disable();
        ui_r_click.Disable();
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
        Debug.Log("Interact Called");
        onPlayerInteract.Raise(this, context.ReadValueAsButton());
    }
    private void l_click(InputAction.CallbackContext context)
    {
        string d;
        if (context.ReadValueAsButton().Equals(true))
            d = "pressed";
        else
            d = "released";
        Debug.Log("Left Click " + d);
        on_l_click.Raise(this, context);

        
    }
}
