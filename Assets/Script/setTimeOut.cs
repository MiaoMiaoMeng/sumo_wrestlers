using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setTimeOut : MonoBehaviour
{
    public Animator animator;
    public float timer = 1.0f;
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= -15.0f)
            animator.SetBool("isTime", true);
    }
}
