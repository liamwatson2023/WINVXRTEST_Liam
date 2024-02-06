using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject Tri;
    public GameObject Cube;
    public float speed;
    void OnTriggerEnter(Collider other)
    {
        Tri.transform.position = Vector3.MoveTowards(Tri.transform.position, Cube.transform.position, speed);
    }


}
