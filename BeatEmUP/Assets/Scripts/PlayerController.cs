using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 5;
    [SerializeField] private float _turnSpeed = 360;
    private Vector3 _input;

    void Update()
    {
        Look();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Look()
    {
        //if (_input != Vector3.zero)
        //{
        Vector3 screenPos = Input.mousePosition;

        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            Vector3 worldPos = raycastHit.point;
            worldPos.y = transform.position.y;
            transform.LookAt(worldPos);
        }


        //screenPos.z = Camera.main.nearClipPlane;
        //Vector3 MousePos = Camera.main.ScreenToWorldPoint(screenPos);
        //MousePos.y = transform.position.y;


        //transform.LookAt(MousePos);

        //var skewedInput = matrix.MultiplyPoint3x4(_input);

        //var relative = (transform.position + _input.ToIso()) - transform.position;
        //var rot = Quaternion.LookRotation(relative, Vector3.up);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnSpeed * Time.deltaTime);
        //}

    }

    void Move()
    {
        Vector3 moveDir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        moveDir = moveDir.normalized;

        _rb.MovePosition(transform.position + moveDir  * _speed * Time.deltaTime);

        //_rb.MovePosition(transform.position + transform.forward * _input.magnitude * _speed * Time.deltaTime);
    }
}
