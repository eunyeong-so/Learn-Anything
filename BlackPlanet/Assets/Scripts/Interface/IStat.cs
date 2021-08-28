using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public interface IStat  
{
    public int HealthPoint { get; set; }
    public int StrikingPower { get; set; }


    public void Death();
   
}
