using UnityEngine;
  
public class MonsterManager : MonoBehaviour  
{
    public GameObject BossMonsterParent; 
    public GameObject BabyMonsterParent;

    private Monster boss;
    private Monster baby;

    public BoxCollider SpawnArea;

    private IClick click;  

    void Start()
    { 
        InitBabyMonster();
        InitBossMonster();

        click.ClickEvent += Damage;

    }
      
    public void Damage(bool isTrue)
    {    
        boss.Damage(isTrue);
        baby.Damage(isTrue);
    }

    private void InitBossMonster()
    {
        GameObject boss = Instantiate(Resources.Load<GameObject>("BossMonster"));
         
        boss.transform.SetParent(BossMonsterParent.transform);

        this.boss = boss.GetComponent<Monster>();

    }

    private void InitBabyMonster()
    { 
        int spawnCount = 10;

        for(int i = 0; i < spawnCount; i++)
        {
            SpawnBabyMonster();
        }

        SpawnArea.enabled = false;
    }
     
    private void SpawnBabyMonster()
    {
        GameObject baby = Instantiate(Resources.Load<GameObject>("BabyMonster"));

        this.baby = baby.GetComponent<Monster>();


        baby.transform.SetParent(BabyMonsterParent.transform);

        baby.transform.position = RandomPosition();
    }

    private Vector3 RandomPosition()
    {
        Vector3 basicPosition = transform.position;
        Vector3 size = SpawnArea.size;

        float posX = basicPosition.x + Random.Range(-size.x / 2f, size.x / 2f);
        float posY = basicPosition.x + Random.Range(-size.y / 2f, size.y / 2f);

        Vector3 SpawnPosition = new Vector3(posX, posY, 0);

        return SpawnPosition;
    }
}
