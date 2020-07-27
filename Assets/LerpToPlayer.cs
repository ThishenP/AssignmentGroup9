using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpToPlayer : MonoBehaviour
{
    
   

    public GameObject player;

    public float speed = 10f;

    void FixedUpdate()
    {
        float lerpRate = speed * Time.deltaTime;

        float y = transform.position.y;
        y = Mathf.Lerp(transform.position.y, player.transform.position.y, lerpRate);
        transform.position = new Vector3(transform.position.x,y,transform.position.z);
    }
}

