using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    public void OnContinue()
    {
        UnityEngine.Debug.Log("HELP");
        SceneManager.LoadScene("Main");
        UnityEngine.Debug.Log("HELP");
    }


}
