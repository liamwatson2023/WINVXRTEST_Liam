using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float forceAmount = 500f;
    Rigidbody m_RigidBody;
    private void Start()
    {

        m_RigidBody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        m_RigidBody.AddForce(-transform.forward * forceAmount, ForceMode.Acceleration);
        Debug.Log("Collision");
        m_RigidBody.useGravity = true;
    }
 

    
       
    
}
