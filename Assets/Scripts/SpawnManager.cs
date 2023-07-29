using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25,0,0);
    private float startDelay = 5;
    private float repeatRate = 2;
    private PlayerController player;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int spawnIndex = Random.Range(0, obstaclePrefab.Length);
        if (player.gameOver == false)
            Instantiate(obstaclePrefab[spawnIndex], spawnPos, obstaclePrefab[spawnIndex].transform.rotation);
    }
}
