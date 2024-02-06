using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Box : MonoBehaviour
{
    public GameObject Chest_1;
    public GameObject Chest_2;
    public GameObject Cube_1;
    public GameObject Cube_2;
    public float speed;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key_2")
        {
            Chest_1.transform.position = Vector3.MoveTowards(Chest_1.transform.position, Cube_1.transform.position, speed);
            Chest_2.transform.position = Vector3.MoveTowards(Chest_2.transform.position, Cube_2.transform.position, speed);

        }
    }
}
