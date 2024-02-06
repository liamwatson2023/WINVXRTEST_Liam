using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    [SerializeField] private InputActionProperty jumpButton;
    [SerializeField] private float jumpHeight = 3f;
    [SerializeField] private CharacterController cc;
    [SerializeField] private LayerMask groundLayers;
    private float gravity = Physics.gravity.y;
    private Vector3 movement;

    private void Update()
    {
        bool isGrounded = IsGrounded();

        if (jumpButton.action.WasPressedThisFrame() && isGrounded)
        {
            DoJump(); 
        }

        if (!isGrounded)
        {
            movement.y += gravity * Time.deltaTime;
        }
        else if (movement.y < 0)
        {
            movement.y = 0; 
        }

        cc.Move(movement * Time.deltaTime);
    }

    private void DoJump()
    {
        movement.y = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
    }

    private bool IsGrounded()
    {
        float checkRadius = 0.1f;
        return Physics.CheckSphere(transform.position, checkRadius, groundLayers);
    }
}

