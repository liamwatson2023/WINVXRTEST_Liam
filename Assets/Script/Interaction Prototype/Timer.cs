using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    [SerializeField] TextMeshProUGUI  countdownText;

    private void Start()
    {
        currentTime = startingTime;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime -= 1* Time.deltaTime;
        countdownText.text = currentTime.ToString("0.0");
    }
}
