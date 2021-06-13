using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTriggerScript : MonoBehaviour
{

    AudioSource audio;
    public GameObject splashParticle;
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

            //ContactPoint contact = collision.contacts[0];
            //Quaternion rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
            Vector3 position = collision.transform.position;
            //Quaternion rotation = Quaternion.Euler(position.x, position.y, position.z);
            var newSplash = Instantiate(splashParticle, position, new Quaternion (0,0,0,0));
            Destroy(newSplash, 1f);
        }

        if (collision.gameObject.name == "Player")
        {

        }
    }

    IEnumerator reset()
    {
        //Wait for 1 second
        yield return new WaitForSeconds(1);
        isPlaying = false;
    }

}