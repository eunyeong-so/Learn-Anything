using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    public Player player;
    public BabyMonster babyMonster;
    public DevilMonster devilMonster;
    public BossMonster bossMonster;
   
    private void Start()
    {
        player = gameObject.AddComponent<Player>();
        babyMonster = gameObject.AddComponent<BabyMonster>();
        devilMonster = gameObject.AddComponent<DevilMonster>();
        bossMonster = gameObject.AddComponent<BossMonster>(); 
    }

    public void SetStat()
    {
        player.SetStat();
        bossMonster.SetStat();
    }
 
    public void BossAtack(DamageType damageType)
    {
        if (bossMonster.HealthPoint > 0)
            player.Damage(bossMonster.StrikingPower, damageType);
      
        if (player.HealthPoint <= 0)
            player.Death();

        PrintHealthPoint();
    }
 
    public void PlayerAttack(DamageType damageType)
    {
        if (player.HealthPoint > 0)
            bossMonster.Damage(player.StrikingPower, damageType);

        if (bossMonster.HealthPoint <= 0)
            bossMonster.Death();

        PrintHealthPoint();
    }
     
    public void PrintHealthPoint()
    {
        Debug.Log("Player health:" + player.HealthPoint);
        Debug.Log("Boss health:" + bossMonster.HealthPoint);
    }

}

