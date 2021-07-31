using UnityEngine;
  
public class MonsterManager : MonoBehaviour  
{
    public Transform BossMonsterParent; 
    public Transform BabyMonsterParent;
    public Transform DevilMosnterParent;
    private InputManager inputmanager = new InputManager();
     
    private BossMonster boss = new BossMonster();
    private BabyMonster baby = new BabyMonster();
    private DevilMonster devil = new DevilMonster();


    void Start()
    {
        InitMonster();
        inputmanager.ClickEvent += Damage;
    } 

    private void InitMonster()
    {
        boss.InitMonster(BossMonsterParent);
        baby.InitMonster(BabyMonsterParent);
        devil.InitMonster(DevilMosnterParent);
    } 
    
    public void Damage()
    {
        Debug.Log("damage");
      
    }
}
