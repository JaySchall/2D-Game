using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    public TMP_Text textEndGame;
    public void GameOver(string endState) { 
        
        switch (endState) 
        {
            case "time over":
                textEndGame.text = "You Ran Out of Time.";
                //display time up game over screen

                break;

            case "caught":
                //display caught game over screen
                textEndGame.text = "You were caught.";
                break;
        }
    
    }
}
