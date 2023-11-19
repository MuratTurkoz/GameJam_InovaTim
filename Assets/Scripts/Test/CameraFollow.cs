using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Takip edilecek hedef
    public float distance = 10.0f; // Hedef ile kamera arasýndaki mesafe
    public float height = 5.0f; // Kameranýn yüksekliði
    //public float heightDamping = 2.0f;
    //public float rotationDamping = 3.0f;
    public Vector3 offset; // Ýsteðe baðlý ekstra ofset

    void LateUpdate()
    {
        if (target == null) return;

        // Kameranýn pozisyonunu ayarla
        Vector3 desiredPosition = new Vector3(target.position.x, target.position.y + height, target.position.z - distance) + offset;
        transform.position = desiredPosition;

        // Kameranýn rotasyonunu sabit tut
        //transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));

    }
}
