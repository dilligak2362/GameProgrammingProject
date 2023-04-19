using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int playerHealth;

    void Start()
    {
        playerHealth = maxHealth;
    }

    public void Damage(int damage)
    {
        playerHealth = playerHealth - damage;
    }
}
