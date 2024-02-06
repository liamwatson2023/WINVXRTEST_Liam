using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DingTrigger : MonoBehaviour
{
    public AudioSource playSound;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Car")
        {
            StartCoroutine(Ding());
        
        }

    }

    IEnumerator Ding()
        {
            playSound.Play();

            yield return new WaitForSeconds(7);

            playSound.Play();

            yield return null;
        }
}
