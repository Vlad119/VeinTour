using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioScript : MonoBehaviour {
    public static AudioScript self;
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public GameObject pl;
    public GameObject pa;

   
	// Use this for initialization
	void Start ()
    {
        if (!self) self = this;
        MusicSource.clip = MusicClip;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space)|| Input.GetKeyDown(KeyCode.Tab))
            PlayCourse();
    }
     
    public void PlayCourse()
    {
        if (MusicSource.isPlaying)
        {
           
            MusicSource.Pause();
            pl.SetActive(true);
            pa.SetActive(false);           
        }
        else
        {
           
            MusicSource.Play();
            pl.SetActive(false);
            pa.SetActive(true);
        }
    }

}
