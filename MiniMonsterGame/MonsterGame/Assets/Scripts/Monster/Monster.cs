using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int HP;
    public int DamagePoint;
    public GameObject Cloud = null;
  

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
      
    public virtual void Damage()
    { 
        HP -= DamagePoint;
        
        if (!IsLive())
            Death();
    }

    public bool IsLive()
    {
        return HP > 0;
    }

    public virtual void Death()
    {
        GetComponent<SpriteRenderer>().color = Color.gray;

        if (Cloud != null)
        {
            Cloud.GetComponent<SpriteRenderer>().enabled = true;
            Cloud.GetComponent<Animator>().enabled = true;
            Cloud.GetComponent<AudioSource>().enabled = true;
        }
        float delayTime = 0.4f;
        Destroy(gameObject, delayTime);
    } 

    public void Attack()
    {
        Debug.Log("Character Attacks");
    }

    public Vector3 GetRandomPosition()
    { 
        Vector3 size = new Vector3(20, 6, 1);
      
        float posX = Random.Range(-size.x / 2f, size.x / 2f);
        float posY =  Random.Range(-size.y / 2f, size.y / 2f);

        Vector3 SpawnPosition = new Vector3(posX, posY, 0);

        return SpawnPosition;
    }

    //To Do: Random speed 
    public virtual void MovingUp()
    {   
        float speed = 0.2f;
        transform.position += Vector3.up * Time.deltaTime * speed;

    } 
}
