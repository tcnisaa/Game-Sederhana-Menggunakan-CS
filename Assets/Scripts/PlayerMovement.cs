using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed; //kecepatan player
    public float JumpForce;

    Rigidbody2D rb;//referensi ke Rigidbody 
    bool Grounded = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Mendapatkan komponen rigidbody dari player
    }

    // Update is called once per frame
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal"); //untuk menginput Pergerakan x yang mana x tersebut sb horizontal
        rb.velocity = new Vector2(MoveX * Speed, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space)&& Grounded == true) //  untuk membuat "space" keyboard sebagai navigasi lompat
        {
            // lompat
            rb.AddForce(transform.up * JumpForce);
            Grounded = false;
        }

    }

    void OnCollisionEnter2D(Collision2D col) // parameter untuk memanggil collision
    {
        if(col.gameObject.tag == "Ground") // jika col mendarat akan  memanggil GROUND
        {
            Grounded = true ; // dan jika coll telah memanggil ground makan = true
        }
    }
}
