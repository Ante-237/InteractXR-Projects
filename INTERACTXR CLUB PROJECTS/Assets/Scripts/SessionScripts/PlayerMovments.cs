using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovments : MonoBehaviour
{

    [SerializeField] private Transform MaximumX;
    [SerializeField] private Transform MinimumX;
    [SerializeField] private float playerSpeed = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementControl();
    }

    public void MovementControl()
    {
        float movement = Input.GetAxisRaw("Horizontal");
       
        transform.position = new Vector3(movement * playerSpeed, transform.position.y, transform.position.z);
        if (transform.position.x > MaximumX.position.x)
        {
            transform.position = new Vector3(MaximumX.position.x, transform.position.y, transform.position.z);
        }

        if (transform.position.x < MinimumX.position.x)
        {
            transform.position = new Vector3(MinimumX.position.x, transform.position.y, transform.position.z);
        }
    }
}
