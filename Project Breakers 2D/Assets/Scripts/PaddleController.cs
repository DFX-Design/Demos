using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    public float maxX;
  
    // Update is called once per frame.
    void Update(){
        //Gets cursor location and sets the movement location to the x axis of the paddle.
        //y axis should remain fixed at -4 as we do not want up and down movement. 
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x,-4);
        
        
        
        //Alternate Keyboard paddle movement.
        // Input is controlled within Unity Project Prefrences.
        float x = Input.GetAxis("Horizontal");

        if(x == 0){
            Stop();
        }

        if(x < 0){
            MoveLeft();
        }

        if(x > 0){
            MoveRight();
        }
        //Paddle Boundaries on the x axis. Makes sure the paddle stays on screen.
        //Dont change maxX here. If modifications are needed use Object Inspector GUI in Unity.   
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-maxX,maxX);
        transform.position = pos;

     
    }
    //Movement speed on x axis while using keyboard contolls.
    //Dont change speed here. If modifications are needed use Object Inspector GUI in Unity.
    void MoveLeft(){
         rb.velocity = new Vector2(-speed,0);
    }

    void MoveRight(){
        rb.velocity = new Vector2(speed,0);
    }

    void Stop(){
        rb.velocity = new Vector2(0,0);
    }


}
