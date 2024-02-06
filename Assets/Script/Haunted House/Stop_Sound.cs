using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop_Sound : MonoBehaviour
{
   
    public AudioSource StopSound;

    void OnTriggerEnter(Collider other)
    {
        StopSound.Stop();
    }
}
