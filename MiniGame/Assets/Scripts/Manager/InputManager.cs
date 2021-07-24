using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class InputManager : MonoBehaviour, IClick
{
    public event ClcikEventHandler ClickEvent;
   
    void Update()
    {
        ClickedBabyMonster();
    }
     
    void ClickedBabyMonster()
    { 

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D[] hits = Physics2D.GetRayIntersectionAll(ray, Mathf.Infinity);
            foreach (var hit in hits)
            {
                if (hit.collider)
                {
                    GameObject selected = hit.collider.gameObject;

                    if (ClickEvent != null)
                        ClickEvent?.Invoke(true);
                    else
                        Debug.Log("ClickEvent is null");
                }
            }
        }
    }
}
