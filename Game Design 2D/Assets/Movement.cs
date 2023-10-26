using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{

    public Rigidbody2D rb;
    public Animator ani;
    public float moveSpeed = 5f;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        //Character movemement is handled with these 2 lines of code 12:00 brackeys for this tutorial
      

        ani.SetFloat("Horizontal", movement.x);
        ani.SetFloat("Vertical", movement.y);
        ani.SetFloat("Speed", movement.sqrMagnitude);
//
        if (Input.GetKeyDown(KeyCode.Escape)) // Check for the Escape key press
        {
            // Load the main menu scene or perform the desired action
            SceneManager.LoadScene("Menu");
        }
     
     
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
