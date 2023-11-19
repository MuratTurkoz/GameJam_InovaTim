using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Takip edilecek hedef
    public float distance = 10.0f; // Hedef ile kamera aras�ndaki mesafe
    public float height = 5.0f; // Kameran�n y�ksekli�i
    //public float heightDamping = 2.0f;
    //public float rotationDamping = 3.0f;
    public Vector3 offset; // �ste�e ba�l� ekstra ofset

    void LateUpdate()
    {
        if (target == null) return;

        // Kameran�n pozisyonunu ayarla
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y + height, target.position.z - distance) + offset;
        transform.position = desiredPosition;

        // Kameran�n rotasyonunu sabit tut
        //transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));

    }
}
