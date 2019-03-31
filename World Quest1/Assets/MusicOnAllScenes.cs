using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicOnAllScenes : MonoBehaviour
{

    AudioSource audioSource;
    public static float volumeValue = 1f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = volumeValue;
    }

    void Update()
    {
        audioSource.volume = volumeValue;
    }

    private static MusicOnAllScenes instance = null;
    public static MusicOnAllScenes Instance
    {
        get { return instance; }
    }

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
    }

}
