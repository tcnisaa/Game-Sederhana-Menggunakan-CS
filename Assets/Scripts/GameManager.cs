using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int Score;
    public Text ScoreTxt;
    public Text WinScoreTxt;
    public AudioSource lose;

    public GameObject GOPanel; // referensi panel mjd gameobject
    public GameObject WinPanel;

    // Start is called before the first frame update
    void Start()
    {
        GOPanel.SetActive(false);
        WinPanel.SetActive(false);
        Score = 0;
        ScoreTxt.text = "Score : " + Score;
    }

    public void UpdateScore()
    {
        Score += 10;
        ScoreTxt.text = "Score : " + Score;
    }

    public void GameOver()
    {
        lose.Play();
        GOPanel.SetActive(true);
    }

    public void Restart() // metode yang akan dipanggil pada saat tombol di klik
    {
        SceneManager.LoadScene(0);
    }

    public void GameCompleted()
    {
        WinScoreTxt.text = "Score : " + Score;
        WinPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
