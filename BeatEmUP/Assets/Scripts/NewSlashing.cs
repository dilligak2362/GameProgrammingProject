using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSlashing : MonoBehaviour
{
    public float speed = 10;
    private Quaternion originalPos;

    void Start()
    {
        originalPos = transform.localRotation;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        else
        {
            transform.localRotation = originalPos;
        }
    }
}
