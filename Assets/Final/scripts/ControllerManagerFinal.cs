using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class ControllerManager : MonoBehaviour
{
    public XRController rightHand;
    public InputHelpers.Button input;
    public bool pressed;
    void Update()
    {
        rightHand.inputDevice.IsPressed(input, out pressed);
    }
}
