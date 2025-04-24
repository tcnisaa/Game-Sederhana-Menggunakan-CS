using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
   public GameObject target;

   public Vector3 offset; //jika kamera berada di posisi berbeda dengan player
   public float Smoothness = 0.125f ; // agar pergerakan kamera berjalan mulus

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null) //jika pemain mati referensi ke kamera jga hrs dihapus
        {
            Vector3 camPos = transform.position; // method untuk posisi kamera
            Vector3 PlayerPos = target.transform.position; // untuk posisi player
            Vector3 desiredPosition = PlayerPos; // untuk mengikuti posisi player
            Vector3 smoothedPoss = Vector3.Lerp(camPos, desiredPosition, Smoothness); // menggabungkan seluruh method yang udh dibuat

            transform.position = smoothedPoss + offset;
        }
        
    }
}
