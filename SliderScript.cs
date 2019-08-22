using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {
    AudioSource audios;
    Slider slider;
    public AudioClip song;

    // Use this for initialization
    void Start()
    {
        audios = GetComponent<AudioSource>();
        slider = GetComponent<Slider>();
        audios.clip = song;
        slider.minValue = 0;
        slider.maxValue = song.length;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = audios.time;
    }
    public void MovePosition()
    {
        if ((audios.time < audios.clip.length)&&(slider.value < audios.clip.length))
        
             audios.time = slider.value;
        
    }
}
