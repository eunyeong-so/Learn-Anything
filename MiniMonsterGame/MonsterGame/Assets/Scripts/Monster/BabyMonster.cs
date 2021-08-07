using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMonster : Monster
{
    private void Start()
    {
        HP = 5;
        DamagePoint = 1;
    }

    void Update()
    {
        MovingUp();
    }
 
    public override void LoadMonster(Transform initPosition)
    {
        GameObject baby = Instantiate(Resources.Load<GameObject>("BabyMonster"));

        baby.transform.SetParent(initPosition);

        baby.transform.position = GetRandomPosition();
    }
}
