using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RB : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private bool useVelocity;

    private Vector2 moveInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (useVelocity)
            rb.velocity = moveInput * 10;
        else
            rb.AddForce(moveInput * 10);
    }

    public void OnMoveDirection(InputAction.CallbackContext callbackContext)
    {
        moveInput = callbackContext.ReadValue<Vector2>();
    }

    public void OnSpin()
    {
        rb.AddTorque(50, ForceMode2D.Impulse);
    }
}
