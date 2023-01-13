using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class followBall : MonoBehaviour {

    
    public GameObject ball;

    void Update() {
        Vector3 ballPosition = ball.transform.position;
        
        transform.position = ballPosition + new Vector3(0, 1f, 0);

        Vector3 ballMovementDirection = ball.GetComponent<Rigidbody>().velocity.normalized;
        
        transform.rotation = Quaternion.LookRotation(ballMovementDirection);
        }
    }
