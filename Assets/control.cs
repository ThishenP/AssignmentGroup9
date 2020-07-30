using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    public Animator anim;
    public Animator endAnim;
    public GameObject endJelly;
    public AudioSource splat;
    public Text scoreText;
    public ParticleSystem part;
    private float timeSinceBounce=0;
    private float score;

    void Update()
    {
        timeSinceBounce += Time.deltaTime;
        if (gameOver==false&&started==true)
        {
            score += Time.deltaTime*3;
        }
        if (started == true)
        {
            scoreText.text = "SCORE: " + (int)score;
        }
        
    }

    public void Jump()
    {
        anim.SetTrigger("bounce");
    }

    public void Bounce()
    {
        
        if (timeSinceBounce>0.4)
        {
            timeSinceBounce = 0;
            splat.Play();
            part.Play();
        }
        
    }

    public void EndGame()
    {
        gameOver = true;
        hud.SetActive(false);
        gameOverScreen.SetActive(true);
        endAnim.SetTrigger("end");
        endJelly.SetActive(true);
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
