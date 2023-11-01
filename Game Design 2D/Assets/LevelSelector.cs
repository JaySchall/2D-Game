using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public int level;
    public Text levelText;
    // Start is called before the first frame update
    // coco Code
    void Start()
    {
       // levelText.text = level.ToString();
    }

    public void OpenScene()
    {
        SceneManager.LoadScene("Level-" + level.ToString());
    }
}
