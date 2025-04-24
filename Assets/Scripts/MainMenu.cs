using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Info()
    {
        SceneManager.LoadScene("PopUpInfo");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Setting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void Register()
    {
        SceneManager.LoadScene("Register");
    }

    public void Login()
    {
        SceneManager.LoadScene("Login");
    }

    public void Score()
    {
        SceneManager.LoadScene("Score");
    }

}
