using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Transform target; // kameranın takip edeceği hedef
    public float distance = 3.0f; // kamera hedefe olan mesafesi 
    public float height = 1.0f; // kamera yüksekliği
    public float damping = 5.0f; // yumuşatma değeri

    void LateUpdate()
    {
        // hedefin pozisyonunu al
        Vector3 wantedPosition = target.position + new Vector3(0, height, -distance);
        // kameranın pozisyonunu al
        Vector3 currentPosition = Vector3.Lerp(transform.position, wantedPosition, damping * Time.deltaTime);
        // kameranın pozisyonunu güncelle
        transform.position = currentPosition;
        // kameranın bakacağı noktayı hedef pozisyonuna ayarla
        transform.LookAt(target);
    }
}