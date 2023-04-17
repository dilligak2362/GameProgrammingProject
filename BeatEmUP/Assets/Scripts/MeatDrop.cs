using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatDrop : MonoBehaviour
{
    public GameObject MeatModel;
    public float health = 100f;
    public Transform transform;



    public void DropMeat()
    {
        Vector3 position = transform.position;
        GameObject meat = Instantiate(MeatModel, position, Quaternion.identity);
        meat.SetActive(true);
        Destroy(meat, 5f);
    }
}
