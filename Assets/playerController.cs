using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{
    public float speedToFullJump=20;
    public float jumpMultiplier=20;
    public Image jumpBar;
    private float jumpPower=0;
    
    void Update()
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
            if (jumpPower<=0)
            {
                jumpPower = 0;
            }
            else
            {
                jumpPower -= Time.deltaTime * speedToFullJump;
            }
        }
        jumpBar.fillAmount = jumpPower / 100;

        if (Input.GetKeyUp("space"))
        {
            if (control.instance.canJump==true)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpPower * jumpMultiplier));
            }
           
        }

    }
}
