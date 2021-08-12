using UnityEngine;

public class GameManager : MonoBehaviour
{ 
    public InputManager Input;
    public MonsterManager monster;
    public HealthSystem health;
    public WindManager Wind;
     
    void Start()
    {
        Input.ClickEvent += monster.Damage;
        if (Wind == null)
            gameObject.AddComponent<WindManager>();
    }
     
}
