using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour 
{
    public int HP;
    public int DamagePoint = 10;
   
    public virtual void InitHP()
    {
          HP = 10;
    }

    public virtual void InitDamagePoint()
    {
        DamagePoint = 1;
    } 

    public void Damage(bool isTrue)
    {
        if (isTrue)
        {
            HP -= DamagePoint;
        }
     
    }

    public bool IsLive()
    {
        return HP > 0;
    }

    public virtual void DeathEffect(bool isTrue)
    { 
        if (isTrue)
        {
            GetComponentInChildren<SpriteRenderer>().color = Color.red;
            Instantiate(Resources.Load<GameObject>("Cloud"), gameObject.transform);

            float delayTime = 0.5f;

            Destroy(gameObject, delayTime);
        }    
    }
     
}
