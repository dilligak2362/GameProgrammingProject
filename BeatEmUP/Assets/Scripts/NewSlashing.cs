using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSlashing : MonoBehaviour
{
    public float speed = 100;
    private Quaternion originalPos;

    [SerializeField]
    private Transform armTransform;

    void Start()
    {
        originalPos = armTransform.localRotation;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            armTransform.Rotate(Vector3.right * speed * Time.deltaTime);
        else
        {
            armTransform.localRotation = originalPos;
        }
    }
}
