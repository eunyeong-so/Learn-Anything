using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMonster : Monster
{
    private const float MaxTime = 5;
    private static float mWindTime = 0;
    private static float mWindTerm = 3;
    private static float mWindPower = 0;

    private void Start()
    {
        HP = 5;
        DamagePoint = 1;
        StartCoroutine(Wind());
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

    IEnumerator Wind()
    {
        yield return null;
        while(true)
        {
            yield return new WaitForSeconds(mWindTerm);
            mWindTerm = Random.Range(0, MaxTime);
            mWindTime = Random.Range(0, MaxTime);
            mWindPower = Random.Range(-0.5f, 0.5f);

            float windTime = Time.time + mWindTime;
            while(windTime > Time.time)
            {
                transform.position += new Vector3(mWindPower * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
        }
    }
}
