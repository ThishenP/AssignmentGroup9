using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public static control instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    public bool gameOver = false;
    public bool canJump = false;
    public bool started=false;
    public GameObject hud;
    public GameObject gameOverScreen;


    public void EndGame()
    {
        gameOver = true;
        hud.SetActive(false);
        gameOverScreen.SetActive(true);
    }

    public void retry()
    {
        SceneManager.LoadScene(1);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
