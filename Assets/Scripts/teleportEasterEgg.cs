using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportEasterEgg : MonoBehaviour
{
    public string targetTag = "Teleport";
    public float rayDistance = 2f;
    public Transform teleportDestination;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            if (hit.collider.CompareTag(targetTag))
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
                rb.Sleep();
                transform.position = teleportDestination.position;
            }
        }
    }
}
