using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasiting : MonoBehaviour
{
    public GameObject Sphere;
    public float RayLine;
    Renderer ren;


    private void Update()
    {
        RaycastHit hit;
        Ray ColorRay = new Ray(transform.position, Vector3.up);
        Debug.DrawRay(transform.position, Vector3.up* RayLine);
        if (Physics.Raycast(ColorRay,out hit,RayLine))
        {
            if(hit.collider.tag == "Object")
            {
                ren = GetComponent<Renderer>();
                ren.material.color = Color.red;
            }
        }
        
    }
}
