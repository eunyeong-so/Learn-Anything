using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster : Monster
{
    private void Start()
    {
        HP = 100;
        DamagePoint = 30;
    }

    public override void InitMonster(Transform initPosition)
    {
        GameObject boss = Instantiate(Resources.Load<GameObject>("BossMonster"));
        boss.transform.SetParent(initPosition);
    }

    public override void Death()
    {
        Bounce();
        base.Death();
    }

    private void WakeUp()
    {
        //To Do: When the boss wakes up, active a collider 
    }

    public void SpecialAttack()
    {
        Debug.Log("Boss: SpecialAttack");
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
