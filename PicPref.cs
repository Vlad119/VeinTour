using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Net;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using System.Xml;
using System.IO;

public class PicPref : MonoBehaviour {
    public Image image;
    public Text text_name;
    public Text text;
    [Header("Edit")]
    public Sprite Texture;
    public string _name;
    public string _desc;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    private void OnValidate()
    {
        image.sprite = Texture;
        text_name.text = _name;
        text.text = _desc;
    }
}
