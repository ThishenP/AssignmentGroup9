using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public float spawnTriggerXpos=1f;
    private GameObject[] platforms;
    private Vector3 poolPos=new Vector2(40,40);
    private int amountOfPrefabs=5;
    private float length;
    private int count = 0;
    private int prevCount = 0;
    private float platformEndPos;
    


    void Start()
    {
        platforms= new GameObject[amountOfPrefabs];
        for (int i = 0; i < amountOfPrefabs; i++)
        {
            platforms[i] = Instantiate(platformPrefab, poolPos, Quaternion.identity);
        }
        spawnPlatform(20);
    }


    void Update()
    {
        if (count==0)
        {
            prevCount = amountOfPrefabs - 1;
        }
        else
        {
            prevCount = count - 1;
        }
        
        platformEndPos = platforms[prevCount].transform.position.x+platforms[prevCount].GetComponent<SpriteRenderer>().bounds.size.x;
        if (platformEndPos <= spawnTriggerXpos)
        {
            Debug.Log(platformEndPos);
            spawnPlatform(15);
        }
    }

    private void spawnPlatform(float xPos)
    {   
        float randHeight = Random.Range(-4.5f, 1.5f);
        float randLength = Random.Range(0.5f, 0.7f);
        platforms[count].transform.position = new Vector2(xPos,randHeight);
        platforms[count].transform.localScale = new Vector2(randLength, platforms[count].transform.localScale.y);
        count++;
        if (count>=amountOfPrefabs)
        {
            count = 0;
        }
    }

    
}
