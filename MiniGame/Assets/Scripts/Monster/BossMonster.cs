using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster : Monster
{
    public override void InitMonster(Transform initPosition)
    {
        GameObject boss = Instantiate(Resources.Load<GameObject>("BossMonster"));
        boss.transform.SetParent(initPosition);
    } 

    public override void InitHP()
    {
        HP = 100;
    }

    public override void InitDamagePoint()
    {
        DamagePoint = 10;
    }
       
    public override void DeathEffect()
    {
        Bounce();
        base.DeathEffect();
    } 

    private void Bounce()
    {
        float speed = 13f;
        float height = 1.4f;

        Vector3 position = transform.position;

        float newPostion = Mathf.Sin(Time.time * speed);

        transform.position = new Vector3(position.x, newPostion, position.z) * height;
    }
}
