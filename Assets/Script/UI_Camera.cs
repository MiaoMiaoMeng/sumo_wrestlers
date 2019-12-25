using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Camera : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        this.transform.RotateAround( target.position, Vector3.up, 15 * Time.deltaTime);
    }
}
