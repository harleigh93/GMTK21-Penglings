using UnityEngine;
using System.Collections;

public class GameMusicPlayer : MonoBehaviour
{

    private static GameMusicPlayer instance = null;
    public static GameMusicPlayer Instance
    {
        get { return instance; }
    }

    public AudioSource music;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        //music.Play();
    }
}
