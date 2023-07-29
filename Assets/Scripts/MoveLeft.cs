using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30f;
    private PlayerController player;
    private float leftBound = -15;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();  
    }

    void Update()
    {
        if (!player.gameStart) return;
        
        if(player.gameOver == false)
        {
            if (player.doubleSpeed)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (speed * 2));
            }
            else
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }
            

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        }
        
    }

    public void UpdateSpeed(int speed)
    {
        this.speed = speed;
    }
}
