using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))] 

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpActionReference;
    [SerializeField] private float jumpForece = 500.0f;

    private Rigidbody _body;

    private bool _IsGrounded => Physics.Raycast(
        new Vector2(transform.position.x, transform.position.y + 2.0f), Vector3.down, 2.0f);

    void Start()
    {
        _body = GetComponent<Rigidbody>();
        jumpActionReference.action.performed += OnJump;
    }


    private void OnJump(InputAction.CallbackContext obj)
    {
        if (!_IsGrounded)  return; 
        _body.AddForce(Vector3.up * jumpForece);
    }
}