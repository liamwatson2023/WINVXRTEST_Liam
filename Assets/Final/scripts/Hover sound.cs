using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHoverSound : MonoBehaviour, IPointerEnterHandler
{
    public AudioClip hoverSound;  // Assign your sound clip in the Unity editor
    private AudioSource audioSource;

    void Start()
    {
        // Add an AudioSource component to the same GameObject
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = hoverSound;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Play the sound when the pointer enters the button
        if (hoverSound != null)
        {
            audioSource.PlayOneShot(hoverSound);
        }
    }
}