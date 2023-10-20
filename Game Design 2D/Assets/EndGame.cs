using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void GameOver(string endState) { 
        
        switch (endState) 
        {
            case "win":
                //display win screen
                break;

            case "time over":
                //display time up game over screen

                break;

            case "caught":
                //display caught game over screen
                break;
        }
    
    }
}
