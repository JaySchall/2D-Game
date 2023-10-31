using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class Lightbulb : MonoBehaviour
{
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
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        light2D.enabled = powered.powered;
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
