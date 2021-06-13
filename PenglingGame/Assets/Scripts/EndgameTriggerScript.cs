using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndgameTriggerScript : MonoBehaviour
{

    public GameObject endingText;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Player")
        {
            endingText.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
