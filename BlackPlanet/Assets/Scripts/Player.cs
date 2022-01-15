using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Player : MonoBehaviour, IStat, IDamageable
{
    public int HealthPoint { get; set; }
    public int StrikingPower { get; set; }

    public void SetStat()
    {
        HealthPoint = 20;
        StrikingPower = 1;
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
        Debug.Log("�÷��̾ ����߽��ϴ�. ��������");
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
