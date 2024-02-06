using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayBackManager : MonoBehaviour
{

    AudioSource audioPlayer;

    public void PlayAudio()
    {
        audioPlayer.Play();
    }
}
