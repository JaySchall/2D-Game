using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    // Start is called before the first frame update
    // coco Code
    void Start()
    {
        
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Main");
    }
}
