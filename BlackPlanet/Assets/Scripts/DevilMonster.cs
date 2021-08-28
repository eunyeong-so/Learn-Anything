using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilMonster : MonoBehaviour  
{
    public int HealthPoint { get; set; }
    public int StrikingPower { get; set; }


    void Start()
    {
        HealthPoint = 5;
        StrikingPower = 1;
    }
 
    
}
