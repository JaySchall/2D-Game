using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cord : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject plugPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Use")) {
            if(!gameObject.transform.IsChildOf(plugPrefab.transform))
            {
                Debug.Log("Not on plug");
            }
            if(!gameObject.transform.IsChildOf(playerPrefab.transform)) 
            {
                Debug.Log("Not on player");
            }
        }
    }
}
