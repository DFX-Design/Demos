using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BrickController : MonoBehaviour
{
    
    public int health = 1;
    public UnityEngine.Object destructableRef;
   
   
        //This checks if the brick was hit by the ball. It then adds 100 points
        // and removes health from the brick
    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ball")
        {
            health--;
            Score.currentScore += 100;

            if(health <= 0)
            {
                ShatterBrick();
            }
            
         }
    }

        
    

    
    //This destroys the intact brick game object and replaces it with the shattered version
    //on the second hit it replaces it with an empty game object. 
   private void ShatterBrick()
   {
       Destroy(gameObject);
       GameObject destructable = (GameObject)Instantiate(destructableRef);
       destructable.transform.position = transform.position;
       Destroy(gameObject);
   }
}
