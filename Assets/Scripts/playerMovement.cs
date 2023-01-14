using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    public float speed = 10f; // ball's speed
    public float rotationSpeed = 10f; // rotation speed of the ball
    private Transform cam; // reference to the main camera
    private Rigidbody rb; // reference to the ball's Rigidbody component

    void Start()
    {
        cam = Camera.main.transform;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveX, 0f, moveZ);
        Vector3 camForward = Vector3.Scale(cam.forward, new Vector3(1, 0, 1)).normalized;
        move = camForward * move.z + cam.right * move.x;
        rb.AddForce(move * speed);

        
    }
}