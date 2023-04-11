using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slashing : MonoBehaviour
{
   void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Enemies"))
        {
            collider.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
        }     
    }
}
