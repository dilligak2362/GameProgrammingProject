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

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            /*if(collider.GetComponent<Health>() != null)
            {
                collider.GetComponent<Health>().Damage(damage);
                this.GetComponent<Health>().Damage(10000);
            } */
        } 
    }
}
