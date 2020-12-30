using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    Slider slider;

    void Awake()
    {
        slider = GetComponent<Slider>();
        slider.value = MusicOnAllScenes.volumeValue;
    }

    void Update()
    {
        MusicOnAllScenes.volumeValue = slider.value;
    }

}
