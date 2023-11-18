using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class ParallaxMove : MonoBehaviour
{
    [SerializeField] private Transform MinimumZ;
    [SerializeField] private Transform MaximumZ;
    [SerializeField] private float PlaneSpeed = 2.0f;

    private float _zMove = 0;

    private void Update()
    {
        _zMove = Mathf.PingPong(Time.time, 10);
        MoveForward();
    }


    private void MoveForward()
    {
        transform.position = Vector3.MoveTowards(transform.position, MinimumZ.transform.position, PlaneSpeed * Time.deltaTime);
        if (transform.position.z <=  MinimumZ.position.z)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, MaximumZ.transform.position.z);
        }
    }
}
