using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    private PlayerController player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.gameStart) return;
        if (!player.gameOver)
        {
            if (player.doubleSpeed)
                score += 2;
            else
                score++;
        }
        Debug.Log("Score: " + score);
    }
}
