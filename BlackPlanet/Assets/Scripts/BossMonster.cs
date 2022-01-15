using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMonster : MonoBehaviour, IStat, IDamageable
{
    public int HealthPoint { get; set; }
    public int StrikingPower { get; set; }

    public void SetStat()
    {
        HealthPoint = 100;
        StrikingPower = 10;
    }

    public void Damage(int strikingPower, DamageType damageType)
    { 
        switch (damageType)
        {
            case DamageType.Attack:
                HealthPoint -= strikingPower;
                break;
            case DamageType.SpeicalAttack:
                HealthPoint -= strikingPower * 2;
                break;
        }
    }

    public void Death()
    { 
        Debug.Log("보스가 사망했습니다. 게임승리");
    }
     
}
