using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int playerHealth;
    public GameObject player;
    public GameObject EndScreen;

    void Start()
    {
        playerHealth = maxHealth;
    }

    void Update()
    {
        EndGame();
    }

    public void Damage(int damage)
    {
        playerHealth = playerHealth - damage;
    }

    public void EndGame()
    {
        if (playerHealth == 0)
        {
            Destroy(player);
            EndScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    void OnCollisionEnter(Collision colliding)
    {
        if (colliding.gameObject.CompareTag("DeathArea"))
        {
            Destroy(player);
            EndScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
