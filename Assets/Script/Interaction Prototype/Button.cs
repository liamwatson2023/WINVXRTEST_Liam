using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PhysicsButton : MonoBehaviour
{
    public Transform buttonTop;
    public Transform buttonLowerLimit;
    public Transform buttonUpperLimit;
    public float threshHold;
    public float force = 10;
    private float upperLowerDiff;
    public bool isPressed;
    private bool prevPressedState;
    public UnityEvent onPressed;
    public UnityEvent onReleased;


    void Start()
    {
        Physics.IgnoreCollision(GetComponent<Collider>(),buttonTop.GetComponent<Collider>());
        if (transform.eulerAngles != Vector3.zero)
        {
            Vector3 savedAngles = transform.eulerAngles;
            transform.eulerAngles = Vector3.zero;
            upperLowerDiff = buttonUpperLimit.position.y - buttonLowerLimit.position.y;
            transform.eulerAngles = savedAngles;
        }
        else
            upperLowerDiff = buttonUpperLimit.position.y - buttonLowerLimit.position.y;
    }

    void Update()
    {
        //keeps button from moving 
        buttonTop.transform.localPosition = new Vector3(0, buttonTop.transform.localPosition.y, 0);
        buttonTop.transform.localEulerAngles = new Vector3(0, 0, 0);

        //stops the button from going higher than the upper limit
        if (buttonTop.localPosition.y >= 0)
            buttonTop.transform.position = new Vector3(buttonUpperLimit.position.x, buttonUpperLimit.position.y, buttonUpperLimit.position.z);
        else
            buttonTop.GetComponent <Rigidbody>().AddForce(buttonTop.transform.up * force * Time.fixedDeltaTime);

        //stops the button from going lower than the lower limit
        if (buttonTop.localPosition.y <= buttonLowerLimit.localPosition.y)
            buttonTop.transform.position = new Vector3(buttonLowerLimit.position.x, buttonLowerLimit.position.y, buttonLowerLimit.position.z);

        //if the button it between the upper and lower limit it will trigger
        if (Vector3.Distance(buttonTop.position, buttonLowerLimit.position) < upperLowerDiff * threshHold)
            isPressed = true;
        else
            isPressed = false;
      
        if (isPressed && prevPressedState != isPressed)
            Pressed();
        if (!isPressed && prevPressedState != isPressed)
            Released();
    }
    //checking if its been pressed
    void Pressed()
    {
        prevPressedState = isPressed;
        onPressed.Invoke();
    }
    //checking if its been released
    void Released()
    {
        prevPressedState = isPressed;
        onReleased.Invoke();
    }
}
