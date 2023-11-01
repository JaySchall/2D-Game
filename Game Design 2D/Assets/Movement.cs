using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Rigidbody2D rb;
    public float speed = 5f;
    public Animator animator;
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    float VerticalMove = 0f;
    Vector2 movement;
    //[SerializeField] private AudioSource moveEffect;
    // public GameOject 
    public bool isWalking;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Character movemement is handled with these 2 lines of code 12:00 brackeys for this tutorial
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        VerticalMove = Input.GetAxisRaw("Vertical") * runSpeed;
        animator.SetFloat("Speed", horizontalMove);
        animator.SetFloat("UpSpeed", VerticalMove);
       // moveEffect.Play();
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
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
       
        if (rb.velocity.x < 0)
        {
            // Flip the sprite to face left
            spriteRenderer.flipX = true;
        }
        else if (rb.velocity.x > 0)
        {
            // Flip the sprite to face right
            spriteRenderer.flipX = false;
        }
    
    }
}
/*
 * using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Rigidbody2D rb;
    public float speed = 5f;
    public Animator animator;
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    float VerticalMove = 0f;
    Vector2 movement;
    [SerializeField] private AudioSource moveEffect;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer();
    }

    // Update is called once per frame
    private void Update()
    {
        // Character movement is handled with these 2 lines of code
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        VerticalMove = Input.GetAxisRaw("Vertical") * runSpeed;
        animator.SetFloat("Speed", horizontalMove);
        animator.SetFloat("UpSpeed", VerticalMove);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Load the main menu scene or perform the desired action
            SceneManager.LoadScene("Menu");
        }

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);

        if (rb.velocity.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (rb.velocity.x > 0)
        {
            spriteRenderer.flipX = false;
        }

        // Play the moveEffect when there is movement
        if (movement.x != 0 || movement.y != 0)
        {
            moveEffect.Play();
        }
    }
}*/