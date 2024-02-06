using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delayed_Trigger : MonoBehaviour
{
    public AudioSource playSound;
    public bool played1x = false;
    void OnTriggerEnter(Collider other)
    {
        Invoke("Run", 1);
    }
    public void Run()
    {
        if (played1x == false)
        {
            playSound.Play();
            played1x = true;
        }
    }
}
