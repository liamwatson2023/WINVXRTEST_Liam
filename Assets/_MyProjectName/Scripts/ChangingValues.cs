using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangingValues : MonoBehaviour
{
    [serializeField] TextMeshProUgi timerText;

    void Update()
    {
        RunTimer(1);
    }

    private void RunTimer(int time)
    {
        float count = 0;
        count += Time.deltaTime;
        if(count >=time)
        {
            timerText.text=count.ToString();
            count= 0;
        }
    }
}
