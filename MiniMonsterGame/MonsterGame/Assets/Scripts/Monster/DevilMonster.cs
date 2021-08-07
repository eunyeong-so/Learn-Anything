using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilMonster : Monster
{ 
    private void Start()
    {
        HP = 10;
        DamagePoint = 1;
    }

    void Update()
    {
        MovingUp();
    }

    public override void LoadMonster(Transform initPosition)
    {
        GameObject devilMonster = Instantiate(Resources.Load<GameObject>("DevilMonster"));

        devilMonster.transform.SetParent(initPosition);

        devilMonster.transform.position = GetRandomPosition();
    }
     

    public void SpecialAttack()
    {
        Debug.Log("Devil: SpecialAttack");
    }


    /* To do: Make Fade Effect
    IEnumerator Fade()
    {    
       
    }*/
}
