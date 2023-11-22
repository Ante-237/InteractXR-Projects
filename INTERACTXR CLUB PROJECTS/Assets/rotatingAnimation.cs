using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatingAnimation : MonoBehaviour
{

    [SerializeField] private float Speed = 20;
    [SerializeField] [Range(1, 20)] private float MoveSpeed = 5f;
 
    void Update()
    {
        // transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y + 5f, transform.rotation.z);
        // transform.Rotate(Vector3.down * (Time.deltaTime * Speed));
        
        transform.Translate(new Vector3(Mathf.Cos(Time.time) / MoveSpeed, 0, Mathf.Sin(Time.time) / MoveSpeed));
    }
}
