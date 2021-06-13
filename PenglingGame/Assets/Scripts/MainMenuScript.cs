using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{

    public GameObject CreditsMenu;
    public AudioSource buttonSound;

    public void PlayButtonPressed()
    {
        buttonSound.Play();
        Application.LoadLevel(1);
    }

    public void QuitButtonPressed()
    {
        buttonSound.Play();
        Application.Quit();
    }

    public void OpenCredits()
    {
        buttonSound.Play();
        CreditsMenu.SetActive(true);
    }

    public void CloseCredits()
    {
        buttonSound.Play();
        CreditsMenu.SetActive(false);
    }
}
