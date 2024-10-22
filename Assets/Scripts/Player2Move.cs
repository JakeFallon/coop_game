using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Move : MonoBehaviour
{

    private float speed = 5f;
    private float horizontal;
    private float vertical;
    [SerializeField] private Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Controller_Horizontal");
        vertical = Input.GetAxisRaw("Controller_Vertical");




        rb.linearVelocity = new Vector2(horizontal * speed, vertical * speed);


    }
}
