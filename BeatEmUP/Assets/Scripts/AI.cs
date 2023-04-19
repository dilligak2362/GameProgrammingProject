using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public Transform target;
    public float range;
    
    [SerializeField]
    public int damage = 2;
    public float speed;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        target = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) {
            float dist = Vector3.Distance(target.position, transform.position);
            if(dist <= range) {
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                transform.LookAt(target.position);
            }
        }
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            if(collider.gameObject.GetComponent<Health>() != null)
            {
                collider.gameObject.GetComponent<Health>().Damage(damage);
                
            } 
        } 
    }
}
