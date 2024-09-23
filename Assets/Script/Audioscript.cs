using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audioscript : MonoBehaviour
{

    private static Audioscript instance;
    // Start is called before the first frame update
    void Awake()
    {   if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }

    public void Mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }

}
