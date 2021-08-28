using NUnit.Framework;
using UnityEngine;

public class DamageTest
{ 
    
    [Test]
    public void AttackToBoss()
    {
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Assert.IsNotNull(gameManager);
         
        gameManager.SetStat();
        gameManager.PrintHealthPoint();

        int originBossHP = gameManager.bossMonster.HealthPoint;
        int expectedBossHP = originBossHP - gameManager.player.StrikingPower;
         
        gameManager.PlayerAttack(DamageType.Attack);
 
        Assert.IsTrue(gameManager.bossMonster.HealthPoint == expectedBossHP);
    }


    [Test]
    public void AttackToPlayer()
    {
        GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        Assert.IsNotNull(gameManager);

        gameManager.SetStat();
        gameManager.PrintHealthPoint();
         
        int originPlayerHP = gameManager.player.HealthPoint;
        int expectedPlayerHP = originPlayerHP - gameManager.bossMonster.StrikingPower;

        gameManager.BossAtack(DamageType.Attack);
     
        Assert.IsTrue(gameManager.player.HealthPoint == expectedPlayerHP);
    }
     
}
