using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int HP;
    public int DamagePoint = 10;
  

    public virtual void InitMonster(Transform initPosition)
    {
        int spawnCount = 10;

        for (int i = 0; i < spawnCount; i++)
        {
            LoadMonster(initPosition);
        }
    }

    public virtual void LoadMonster(Transform initPosition)
    {

    } 

    public virtual void InitHP()
    {
    }

    public virtual void InitDamagePoint()
    {
    }

    public void Damage()
    {
        HP -= DamagePoint;
        Debug.Log("Damage");
    }

    public bool IsLive()
    {
        return HP > 0;
    }

    public virtual void Attack()
    {
    }

    public virtual void SpecialAttack()
    {
    }

    public virtual void DeathEffect()
    {
        GetComponentInChildren<SpriteRenderer>().color = Color.red;
        Instantiate(Resources.Load<GameObject>("Cloud"), gameObject.transform);

        float delayTime = 0.5f;

        Destroy(gameObject, delayTime);

    }

    public Vector3 RandomPosition()
    { 
        Vector3 size = new Vector3(20, 6, 1);
      
        float posX = Random.Range(-size.x / 2f, size.x / 2f);
        float posY =  Random.Range(-size.y / 2f, size.y / 2f);

        Vector3 SpawnPosition = new Vector3(posX, posY, 0);

        return SpawnPosition;
    }


    //To Do: Random speed 
    public void MovingUp()
    {   
        float speed = 2f;
        transform.position += Vector3.up * Time.deltaTime * speed;
    }

}
