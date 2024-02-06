using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object Entered the Trigger");
        Color randomColorSelect = GetRandomColor();
        GetComponent<Renderer>().material.color = randomColorSelect;
    }
    public Color GetRandomColor()
    {
        return new Color(r: UnityEngine.Random.Range(0f, 1f), g: UnityEngine.Random.Range(0f, 1f), b: UnityEngine.Random.Range(0f, 1f));
    }
        
        

}
