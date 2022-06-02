using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{

    private int nextSceneToLoad;

    //Uses the File=>Build Settings to determine active scene and queue up the next one. 
    private void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    //Checks if there are any remaining bricks and once they are all destroyed 
    //loads the next level
    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Brick").Length == 0)
        {
         LevelUp();
        }
    }
    //Transitions to the next level queued in File=>Build Settings.
    private void LevelUp()
    {
        SceneManager.LoadScene(nextSceneToLoad);
    
    }
    //This controls the restart button on the Game Over screen. 
    //Resets to level 1, and clears player score. 
    public void RestartButton()
    {
        SceneManager.LoadScene("Level 1");
        Score.currentScore = 0;
    }
  
   
}
