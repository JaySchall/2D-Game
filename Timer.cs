using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{

    public EndGame endGameScript; // Import EndGame Script so game over screen can be displayed when time runs out
    public TMP_Text textTimer; //Uses TMPro to display timer on screen

    bool timerIsRunning = false; // Gives ability to start/stop timer
    float secPerMin = 1; // The amount of realtime seconds that will pass per each minute in game
    string currentTime; // Current time being displayed on screen
    int currentHr; // numerical representation of the current hour of the day in the game
    int currentMins; // numerical representation of the current minute in the game

    string startingTime; // Time at which the level starts
    int startingHr; // numerical representation of the starting hour of the day in the game
    int startingMins; // numerical representation of the starting minute of the day in the game

    string endTime; // Time at which sun will rise and time will be up
    int endHr; // numerical representation of the ending hour of the day in the game
    int endMins; // numerical representation of the ending hour of the day in the game


    private bool isAm = false;

    int maxHours = 24; // Number of hours in a day
    int maxMinutes = 60; // Number of minutes in an hour

    float timerCount; // variable that can adjust how fast a minute in game is compared to a minute real time

    private string _currentTimeText; // Displays the time as Text on the UI
    private string _endTimeText; // Displays the time as Text on the UI

    string[] endState = {"time over", "caught" }; // array holding the end of game states
    // Start is called before the first frame update
    void Start()
    {
        startingHr = 23; // example time for proof of concept can change to variable value at later time
        startingMins = 30;// example time for proof of concept can change to variable value at later time
        startingTime = SetTimeDateString(startingHr, startingMins);
        timerIsRunning = true;
        currentTime = startingTime;
        currentHr = startingHr;
        currentMins = startingMins;
        endHr = 5; // example time for proof of concept can change to variable value at later time
        endMins = 0; // example time for proof of concept can change to variable value at later time
        endTime = SetTimeDateString(endHr, endMins);

        // Update the current and end time on screen
        textTimer.text = currentTime;
    }

    // Update is called once per frame
    void Update()
    {
        while (timerIsRunning)
        {
            if (timerCount >= secPerMin)
            {
                currentMins++;

                if (currentMins >= maxMinutes) // If current mintutes reaches 60 it will reset to 0 and then add an hour the currentHr variable
                {
                    currentMins = 0;
                    currentHr++;
                }

                if (currentHr >= maxHours) // If current hours goes over 24 it will reset to 0
                {
                    currentHr = 0;
                }
                // Update the current time displayed on the screen
                currentTime = SetTimeDateString(currentHr, currentMins);
                // reset timer so time update is stable
                timerCount = 0;

                // stop the timer once the current time is the same as the end time
                if (currentHr == endHr && currentMins == endMins)
                {
                    //call end game method
                    timerIsRunning = false;
                    endGameScript.GameOver(endState[0]); // call end game script with time ran out designation
                }

                // Update the current time on screen
                /*
                 * 
                 * 
                 *  Add current time update code HERE
                 * 
                 * 
                 * 
                 */
            }
            else
            {
                timerCount += Time.deltaTime;
            }
        }
    }

    string SetTimeDateString(int hr, int min)
    {
        string _time;

        if (hr >= 12 && hr < 24)
        {
            isAm = false;
        }
        else
        {
            isAm = true;
        }

        if (hr >= 13) // If hour is over 12 subtract 12 in order to shout 12 hour format on clock
        {
            hr = hr - 12;
        }
        else if (hr == 0) // If hour is 0 set to 12 for midnight
        {
            hr = 12;
        }
        else //if hour is 12 or less then keep as is
        {
            hr = hr;
        }

        // Set the hour of the time
        _time = hr + ":";

        if (min <= 9) // If minute is less than 9 a leading zero will be added
        {
            _time += "0" + min;
        }
        else
        {
            _time += min;
        }

        if (isAm)
        {
            _time += " AM";
        }
        else
        {
            _time += " PM";
        }

        return _time;
    }
}
