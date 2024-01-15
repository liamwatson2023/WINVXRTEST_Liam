using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HitTarget : MonoBehaviour
{
    [SerializeField] protected int score = 1;

    protected virtual int CalculateScore()
    {
       Debug.Log("Gained"+ score,this.gameObject);
       return score; 
    }
    
    protected void Update()
    {
        TestHitTarget();
    }
    void TestHitTarget()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit))
            {
                if(hit.collider.gameObject.TryGetComponent<HitTarget>(out HitTarget hitTarget))
                {
                    hitTarget.TakeHit(1);
                }
            }
        }
    }
    public virtual void TakeHit(int hitpower)
    {
        int gainScore=CalculateScore();
    }
}