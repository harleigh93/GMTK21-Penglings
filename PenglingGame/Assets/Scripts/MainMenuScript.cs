using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public void PlayButtonPressed()
    {
        Application.LoadLevel(1);
    }

    public void QuitButtonPressed()
    {
        Application.Quit();
    }
}
