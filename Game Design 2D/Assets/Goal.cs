using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    [SerializeField] private AudioSource LevelComplete;
    private Light2D light2D;
    // Start is called before the first frame update
    void Start()
    {
        light2D = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Power powered = GetComponent<Power>();
        if (powered.powered)
        {
            Win();
        }
    }

    void Win()
    {
        SceneManager.LoadScene("Level Completed");
        LevelComplete.Play();
    }
}
