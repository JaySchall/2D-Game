using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plug : MonoBehaviour
{
    public GameObject[] electronics;
    private bool active = false;
    [SerializeField] private AudioSource plugEffect;

   // private AudioClip plugSound;
    // Start is called before the first frame update
    void Start()
    {
    //    plugSound = (AudioClip)Resources.Load("PlugOutlet");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount > 0 && !active)
        {
            Debug.Log("Activated");
            active = true;
            plugEffect.Play();
         //   StartCoroutine(PlaySound());
        //    audioSource.clip = plugSound;
           // audioSource.Play();
            foreach (GameObject electronic in electronics)
            {
                Power powered = electronic.GetComponent<Power>();
                powered.powered = true;
            }
        }
        else if (transform.childCount == 0 && active)
        {
            Debug.Log("Deactivated");
            active = false;
            //  audioSource.clip = plugSound;
            //    audioSource.Play();
           // plugEffect.Play();
            foreach (GameObject electronic in electronics)
            {
                Power powered = electronic.GetComponent<Power>();
                powered.powered = false;
            }
        }
    }

  /*  IEnumerator PlaySound()
    {
        audioSource.clip = plugSound;
        audioSource.Play();
        yield return new WaitUntil(() => audioSource.isPlaying == false);
        foreach (GameObject electronic in electronics)
        {
            Power powered = electronic.GetComponent<Power>();
            powered.powered = true;
        }
    }*/
}
