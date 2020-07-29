using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teethPos : MonoBehaviour
{
    public GameObject player;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float lerpRate = speed * Time.deltaTime;

        float y = transform.position.y;
        y = Mathf.Lerp(transform.position.y, player.transform.position.y, lerpRate);
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
    }
}
