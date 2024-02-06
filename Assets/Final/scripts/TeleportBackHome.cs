using System.Collections;
using UnityEngine;

public class CarTrigger : MonoBehaviour
{
    public GameObject Teleport;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {
            Teleport.SetActive(true);
        }
    }
}