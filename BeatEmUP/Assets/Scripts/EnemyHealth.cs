using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;
    public MeatDrop meat;
  
    void Start()
    {
        currentHealth = maxHealth; 
    }

  
    void Update()
    {
        
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            Destroy(gameObject);
            meat.DropMeat();
        }
    }
}
