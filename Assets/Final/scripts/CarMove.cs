using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public Transform car;           // Reference to the car object
    public float normalSpeed = 2f;  // Speed when not affected by obstacles
    public float slowSpeed = 0f;    // Speed when affected by the "slow" obstacle

    private float currentSpeed;
    private bool isMoving = true;

    void Start()
    {
        currentSpeed = normalSpeed;
    }

    void Update()
    {
        if (isMoving)
        {
            // Move the car forward
            car.Translate(Vector3.up * currentSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Stop"))
        {
            // If any object enters the trigger, stop the car
            isMoving = false;
            currentSpeed = 0f;
        }
        else if (other.CompareTag("Player"))
        {
            // If an object with the tag "player" enters the trigger, set the speed to normal
            currentSpeed = normalSpeed;
        }
    }

    void OnTriggerExit(Collider other)
    {
        // If any object exits the trigger, set the car to slow speed
        currentSpeed = slowSpeed;
        isMoving = true;
    }

    
  
}
