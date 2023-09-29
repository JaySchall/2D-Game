using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject childPrefab;
    // Start is called before the first frame update
    void Start()
    {
        if (childPrefab != null)
        {
            GameObject child = Instantiate(childPrefab);
            child.transform.SetParent(transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
