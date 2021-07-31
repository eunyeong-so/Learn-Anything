using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMonster : Monster
{ 
    void Update()
    {
        MovingUp();
    }

    public override void LoadMonster(Transform initPosition)
    {
        GameObject baby = Instantiate(Resources.Load<GameObject>("BabyMonster"));

        baby.transform.SetParent(initPosition);

        baby.transform.position = RandomPosition();
    }

    public override void InitHP()
    {
        HP = 5;
    }

    public override void InitDamagePoint()
    {
        DamagePoint = 1;
    }
}
