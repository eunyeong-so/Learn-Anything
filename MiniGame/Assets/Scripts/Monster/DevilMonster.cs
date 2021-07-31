using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilMonster : Monster
{
    /// <summary>
    /// To do
    ///
    /// Attack(Turn off the light)
    /// Special Attack (damage to player health)
    /// Make Fade Effect
    /// </summary>
     
    private GameObject light;

    private void Start()
    {
      //light = GetComponentInChildren<Canvas>().gameObject;
    }

    void Update()
    {
        MovingUp();
    }

    public override void LoadMonster(Transform initPosition)
    {
        GameObject devilMonster = Instantiate(Resources.Load<GameObject>("DevilMonster"));

        devilMonster.transform.SetParent(initPosition);

        devilMonster.transform.position = RandomPosition();
    }

    public override void InitHP()
    {
        HP = 5;
    }

    public override void InitDamagePoint()
    {
        DamagePoint = 1;
    }

    public override void Attack()
    {
        StartCoroutine(Fade()); 
    }

    IEnumerator Fade()
    { 
        light.SetActive(true);
        yield return new WaitForSeconds(1f);

        light.SetActive(false);
    }

    public override void SpecialAttack()
    { 
        DamagePoint = 1;
    } 
}
