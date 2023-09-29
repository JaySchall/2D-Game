using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plug : MonoBehaviour
{
    public GameObject electronic;
    private bool active = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 0 && !active)
        {
            Debug.Log("Activated");
            active = true;
            Power powered = electronic.GetComponent<Power>();
            powered.powered = true;
        }
        else if (transform.childCount == 0 && active)
        {
            Debug.Log("Deactivated");
            active = false;
            Power powered = electronic.GetComponent<Power>();
            powered.powered = false;
        }
    }
}