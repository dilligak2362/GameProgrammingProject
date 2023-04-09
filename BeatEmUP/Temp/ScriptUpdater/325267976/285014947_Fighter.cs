using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    private Animator anim;
    public float cooldownTime = 2f;
    private float nextFireTime = 0f;
    public static int noOfClicks = 0;
    float lastClickedTime = 0;
    float maxComboDelay = 1;
    public bool animation_bool;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (animation_bool == true)
        {
            GetComponent<Animation>().Play("Slash");
        }
        if (Input.KeyDown(KeyCode.K))
        {
            animation_bool = true;
        }
    }
}

