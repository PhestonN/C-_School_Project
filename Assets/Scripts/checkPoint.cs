using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public Transform chracter;
    private Rigidbody rb;
    private Vector3 spawnPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("CheckPoint"))
        {
            spawnPoint = other.transform.position;
            
        }
        if (other.gameObject.CompareTag("Death"))
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.Sleep();
            spawn();

        }
        
    }
    private void spawn()
    {
        
        chracter.position = spawnPoint;
    }
}