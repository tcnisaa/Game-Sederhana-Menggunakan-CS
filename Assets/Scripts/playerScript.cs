using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI ;

public class playerScript : MonoBehaviour
{

    public GameManager gameManager;
    public AudioSource coin;


    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D hit)
    {

        if (hit.gameObject.tag == "Gem")
        {
            coin.Play();
            gameManager.UpdateScore();
            Destroy(hit.gameObject);
        }

        if (hit.gameObject.tag == "FinishGem")
        {
            gameManager.GameCompleted();
            Destroy(hit.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Spike")
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "Square")
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }

        if (col.gameObject.tag == "Enemy")
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }
    }
}
