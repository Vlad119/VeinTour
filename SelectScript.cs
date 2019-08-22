using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectScript : MonoBehaviour {
    public static SelectScript self;
 
    public void Select()
    {
        BottomBar.self.jj = (Convert.ToInt32(gameObject.name))-1;
        MainScript.self.AllClose();
        BottomBar.self.photo_off.SetActive(false);
        MainScript.self.fon_too_much_photo.SetActive(true);
        BottomBar.self.photo_on.SetActive(true);
       
        Debug.Log(gameObject.name);
        ScrollSnapRect.self.SetPage(Convert.ToInt32(gameObject.name)-1);
        int p = (Convert.ToInt32(gameObject.name));
        MainScript.self.page.text = "Фото "+p+ " из 41";        
    }

   
	// Use this for initialization
	void Start ()
    {
        self = this;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
