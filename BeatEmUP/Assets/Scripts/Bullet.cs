using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    public MeatDrop meatt;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemies"))
        {
            collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
        }
        Destroy(gameObject);
        meatt.DropMeat();
    }
}
