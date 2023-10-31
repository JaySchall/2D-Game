using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Sprite open;
    private BoxCollider2D boxCollider;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Power powered = GetComponent<Power>();
        if (powered.powered)
        {
            boxCollider.enabled = false;
            spriteRenderer.sprite = open;
        }
    }
}
