using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int currentScore;
    public  TextMeshProUGUI finalScoreText;

    


    // Update is called once per frame.
    //Sets the score text in the UI to display the current score.
    //Sets the final score text to the final score in Game over screen UI. 
    void Update()
    {
        scoreText.text = "Score: "+ currentScore;
        finalScoreText.text = "Score: "+ currentScore;
    }

    
}
