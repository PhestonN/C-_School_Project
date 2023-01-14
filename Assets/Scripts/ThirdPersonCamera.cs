using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{  
    
    public Transform target; 
    public Vector3 offset; 
    public float smoothSpeed = 0.125f;
    private Quaternion originalRotation; 
    

    void Start() {
        originalRotation = transform.rotation; 
    }
    void LateUpdate()
    {
        transform.position = target.position + Quaternion.Euler(0, target.eulerAngles.y + 90, 0) * offset; 
        
        transform.LookAt(target); 
        
    }
    }
