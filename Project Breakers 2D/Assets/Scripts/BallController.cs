using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

     public Rigidbody2D rb;
     public float yballForce;
     public float xballForce;
     bool gameStarted = false;
     bool gameOver = false;
     public UnityEngine.GameObject ballRespawn;
     public UnityEngine.GameObject ball;
     Vector2 newBallPosition;   

  
    void Update()
    {
        //Checks to see if game is in start position, if it is,
        // it allows player to start by hitting space when the game is not started or over. 
        if(Input.GetKeyUp(KeyCode.Space) && gameStarted == false && gameOver == false)
        {
            StartBall();
            StartForce();
            
        }
        //Checks to see if the ball is out of bounds. If it is it resets the ball and removes velocity.
       if(transform.position.y <= -5.7)
        {
           RemoveForce();
            ResetBall();
            
        }


    }
    //This puts the ball in play and enables ball physics. 
    void StartBall()
    {
        rb.isKinematic = false;
        transform.SetParent(null);
        gameStarted = true;
    }
     //This adds the initial force to the ball. It is important to have some force on the x axis
     //to avoid the ball geting stuck bouncing in a straight line.  
    void StartForce()
    {
        rb.AddForce(new Vector2(xballForce,yballForce));
    }
    //This resets the ball if it goes out of bounds, puts the ball back into starting position
    //and subtracts a life.
    void ResetBall()
    {
        Lives.playerLives --;   
        transform.SetParent(ballRespawn.transform);
        transform.position = ballRespawn.transform.position;
        rb.isKinematic = true;
        gameStarted = false;

            if(Lives.playerLives == 0)
            {
                gameOver = true;
            }
    }  
    //This removes the velocity of the ball on both the x and y axis. This is necesary 
    // so the ball will not have downwards force when putting it back in play.      
    void RemoveForce()
    {
          rb.velocity = new Vector2(0,0);
    }
}
