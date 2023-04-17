using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    public int value;

    void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            MeatCounter.instance.IncreaseMeats(value);
        }
    }
}
