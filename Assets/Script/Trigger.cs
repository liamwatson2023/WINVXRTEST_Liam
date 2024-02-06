using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public AudioSource playSound;
    public bool played1x = false;
    void OnTriggerEnter(Collider other)
    {
        if (played1x == false)
        {
            playSound.Play();
            played1x=true;
        }
        
    }
}