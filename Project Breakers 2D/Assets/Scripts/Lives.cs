using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Lives : MonoBehaviour
{
  public  TextMeshProUGUI livesText;
  public static int playerLives;
    public GameObject gameOver;
    //Resets player lives to 3 at the start of each game.
    void Start()
    {
        playerLives = 3;
    }

    
    void Update()
    {
        //Grants bonus lives every 5000 points. Grants 100 points as a bonus to the player 
        //and to ensure current points does not remain divisable by 5000 resulting in infinite lives. 
       livesText.text = "Lives: " + playerLives;
       if (Score.currentScore > 0 && Score.currentScore % 5000 == 0) 
       {
           playerLives +=1;
           Score.currentScore +=100;
       }
        //Checks if lives are at 0, if so ends the game.
       if (playerLives ==0){
           GameOver();
       }
    }
    //Makes the Game Over screen active, ending the game. 
    public void GameOver(){
         gameOver.SetActive(true);
    }
}
