using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightbulb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Power powered = GetComponent<Power>();
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (powered.powered)
        {
            spriteRenderer.color = Color.white;
        }
        else if (!powered.powered)
        {
            spriteRenderer.color = Color.black;
        }
    }
}
