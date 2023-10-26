using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cord : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject plugPrefab;
    private bool checkCollision = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Use")) {
            checkCollision = true;
            
        }
        if (Input.GetButtonUp("Use"))
        {
            checkCollision = false;
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (!checkCollision)
        {
            return;
        }
        checkCollision = false;
        if (other.CompareTag("Plug"))
        {
            Debug.Log("Collided with plug");
            GameObject plug = other.gameObject;
            transform.SetParent(plug.transform);
            transform.position = new Vector3(plug.transform.position.x, plug.transform.position.y, transform.position.z);
        }
        if (other.CompareTag("Player"))
        {
            Debug.Log("Collided with player");
            GameObject player = other.gameObject;
            transform.SetParent(player.transform);
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
        }
    }
 }
