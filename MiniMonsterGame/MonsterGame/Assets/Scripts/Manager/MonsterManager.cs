using System;
using System.Collections;
using System.Reflection;
using UnityEngine;
  
public class MonsterManager : MonoBehaviour  
{
    public Transform BossMonsterParent; 
    public Transform BabyMonsterParent;
    public Transform DevilMosnterParent;

    private BossMonster boss;
    private BabyMonster baby;
    private DevilMonster devil;
 
 
    void Start()
    {
        boss = BossMonsterParent.GetComponent<BossMonster>();
        baby = BabyMonsterParent.GetComponent<BabyMonster>();
        devil = DevilMosnterParent.GetComponent<DevilMonster>();
 
        InitMonster();

        //Test 
        InvokeRepeating("DoAttack", 4, 2);
    }
     

    private void InitMonster()
    {
        boss.InitMonster(BossMonsterParent);
        baby.InitMonster(BabyMonsterParent);
        devil.InitMonster(DevilMosnterParent);
    } 
    
    public void Damage(GameObject selected)
    {
        Debug.Log("damage :" + selected.name);
        selected.GetComponent<Monster>().Damage();
    }

    //Test 
    public void GetAttack(object monsterObject)
    {
        MethodInfo SpecialAttackMethodInfo = monsterObject.GetType().GetMethod("SpecialAttack");
         
        if(SpecialAttackMethodInfo == null)
        {
            Debug.Log("SpecialAttackMethodInfo is null, Do just Attack");
            monsterObject.GetType().GetMethod("Attack");
        }
        else
        {
            System.Object SpecailAttackInstance = Activator.CreateInstance(monsterObject.GetType(), null);
            SpecialAttackMethodInfo.Invoke(SpecailAttackInstance, null);
        } 
    }

    //Test 
    private void DoAttack()
    { 
        GetAttack(boss);
        GetAttack(baby);
        GetAttack(devil);
    } 
     
}
