using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross_Move : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    public AudioSource playSound;
    public bool played1x = false;
    void OnTriggerEnter(Collider other)
    {
        if (played1x == false)
        {
            playSound.Play();
            played1x = true;
            transform.Rotate(_rotation * Time.deltaTime);
        }

    }

}
