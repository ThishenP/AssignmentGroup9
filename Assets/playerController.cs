using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class playerController : MonoBehaviour
{
    public float speedToFullJump=20;
    public float jumpMultiplier=20;
    public Image jumpBar;
    public GameObject startText;
    private float jumpPower=0;
    private float startSize;
    private float startTimer=0;
    private float startGravity;
    


    void Start()
    {
        startSize = transform.localScale.y;
        startGravity = GetComponent<Rigidbody2D>().gravityScale;
        GetComponent<Rigidbody2D>().gravityScale = 0;
        
    }
    void Update()
    {
        if (control.instance.started==false && Input.GetKeyDown("space"))
        {
            control.instance.started = true;
            GetComponent<Rigidbody2D>().gravityScale = startGravity;
            startText.SetActive(false);
        }
        if (control.instance.gameOver==false&&control.instance.started==true)
        {
            if (Input.GetKey("space"))
            {
                if (jumpPower >= 100)
                {
                    jumpPower = 100;
                }
                else
                {
                    jumpPower += Time.deltaTime * speedToFullJump;
                }

            }
            else
            {
                if (jumpPower <= 0)
                {
                    jumpPower = 0;
                }
                else
                {
                    jumpPower -= Time.deltaTime * speedToFullJump;
                }
            }
            jumpBar.fillAmount = jumpPower / 100;
            transform.localScale = new Vector2(transform.localScale.x, startSize - jumpPower / 2000);
            if (Input.GetKeyUp("space"))
            {
                if (control.instance.canJump == true)
                {
                    GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpPower * jumpMultiplier));
                }
            }
        }

        if (transform.position.y < -7 || transform.position.x < -9.6f)
        {
            control.instance.EndGame();
        }
       

    }
}
