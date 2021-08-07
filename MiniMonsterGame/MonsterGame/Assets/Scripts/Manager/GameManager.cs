using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    public InputManager Input;
    public MonsterManager monster;
    public HealthSystem health;
     
    void Start()
    {
        Input.ClickEvent += monster.Damage;
    }
     
}
