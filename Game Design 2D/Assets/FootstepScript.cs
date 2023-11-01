using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepScript : MonoBehaviour
{
    public GameObject footstep;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        footstep.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<Movement>().isWalking)
        {
            PlayFootsteps();
        }
        else
        {
            StopFootsteps();
        }
    }

    // Function to play footstep effects
    void PlayFootsteps()
    {
        footstep.SetActive(true);
        // Add code here to play the footstep effects or animations
    }

    // Function to stop footstep effects
    void StopFootsteps()
    {
        footstep.SetActive(false);
        // Add code here to stop the footstep effects or animations
    }
}