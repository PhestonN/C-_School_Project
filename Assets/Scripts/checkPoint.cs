using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour
{
    public Transform chracter;
    
    private Vector3 spawnPoint;
    void Start()
    {
        
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
            spawn();

        }
        
    }
    private void spawn()
    {
        chracter.position = spawnPoint;
    }
}