using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backToPool : MonoBehaviour
{
    private Vector3 poolPos = new Vector2(40, 40);

    void Update()
    {
        if (transform.position.x<-30)
        {
            transform.position = poolPos;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            control.instance.canJump = true;
            control.instance.Bounce();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            control.instance.canJump = false;
        }
    }
}
