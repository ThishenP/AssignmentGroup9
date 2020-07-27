using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scroll : MonoBehaviour
{
    public float scrollSpeed=2;

    void Start()
    {
        
    }


    void Update()
    {
        if (control.instance.gameOver == false && transform.position.x < 20)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-scrollSpeed, 0);
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
      
    }
}
