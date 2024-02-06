using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpecificObjectOnTrigger : MonoBehaviour
{
    // Serialize this field so you can set the target object in the Unity Editor
    [SerializeField] private GameObject objectToDestroy;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger has the tag "Vest"
        if (other.CompareTag("Vest"))
        {
            // Destroy the specified object after 1 second
            if (objectToDestroy != null)
            {
                Destroy(objectToDestroy, 1f);
            }
        }
    }
}
