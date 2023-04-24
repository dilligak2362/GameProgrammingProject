using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offset = new Vector3(0, 30, -10);

    [SerializeField] private Transform target;
    [SerializeField] private float smoothTime;
    private Vector3 _currentVelocity = Vector3.zero;

    private void LateUpdate()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothTime);
    }
}
