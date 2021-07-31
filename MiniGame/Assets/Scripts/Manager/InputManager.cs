using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class InputManager : MonoBehaviour, IClick
{
    public event ClcikEventHandler ClickEvent;
      
    void Update()
    {
        ClickedMonster();
    }

    void ClickedMonster()
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
                    {
                        Debug.Log("ClickEvent 실행");
                        ClickEvent?.Invoke();
                    }
                    else
                        Debug.Log("ClickEvent is null");
                }
            }
        }
    }


    /*  void Test(object myObject)
     {
         MethodInfo mi = myObject.GetType().GetMethod("Test");
         if (mi != null)
             mi.Invoke(myObject, null);
         else
             Debug.Log("null");
     }*/
}
