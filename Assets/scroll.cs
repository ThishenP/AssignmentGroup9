using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public float scrollSpeed=2;
    public float scrollStopSpeed=4;

    void Start()
    {
        
    }


    void Update()
    {
        if (control.instance.gameOver == false && transform.position.x < 22 && control.instance.started == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-scrollSpeed, 0);
        }
        else
        {
            if (control.instance.gameOver==true)
            {
                if (scrollSpeed > 0)
                {
                    scrollSpeed -= Time.deltaTime * scrollStopSpeed;
                }
                GetComponent<Rigidbody2D>().velocity = new Vector2(-scrollSpeed, 0);
            }
          
        }


      
    }
}
