using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private int health = 3;
    private int damage = 1;
 
    public void healthDamage()
    {
        health -= damage;
    }

    public void healthCheck()
    {
        if (health == 0)
        {
            Debug.Log("No health, Game Over");
            EditorApplication.isPlaying = false;
        }
           
    }
}
