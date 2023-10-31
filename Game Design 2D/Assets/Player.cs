using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera cam;
    public GameObject childPrefab;
    // Start is called before the first frame update
    void Start()
    {
        if (childPrefab != null)
        {
            GameObject child = Instantiate(childPrefab);
            child.transform.SetParent(transform);
            cam.transform.SetParent(transform);

            child.transform.position = new Vector3(transform.position.x,transform.position.y, child.transform.position.z);
            cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
