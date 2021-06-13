using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTriggerScript : MonoBehaviour
{

    AudioSource audio;
    private bool isPlaying = false;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (!isPlaying)
        {
            isPlaying = true;
            audio.Play();
            StartCoroutine(reset());
        }

        if (collision.gameObject.name == "Player")
        {

        }
    }

    IEnumerator reset()
    {
        //Wait for 2 seconds
        yield return new WaitForSeconds(2);
        isPlaying = false;
    }

}