using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Vector3_Demo : MonoBehaviour
{ 

    public float moveSpeed = 3.0f; // Speed at which the object moves
    public float rotationSpeed = 25f; //speed at which the object turns

    private void Update()
    {
        // Check for user input to move the object 
        if (Input.GetKey(KeyCode.W))
        {
            // Move the object forward based on its current postion
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // Move the object back based on its current postion
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            // Move the object left based on its current postion
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Move the object right based on its current postion
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Move the object up based on its current postion
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Move the object down based on its current postion
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Move the object turn left based on its current postion
            transform.Rotate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Move the object turn right based on its current postion
            transform.Rotate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        Vector3 position = transform.position;
        Debug.Log("Position: " + position.ToString());

    }
}
