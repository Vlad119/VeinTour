using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FonSettingsScript : MonoBehaviour {
    public static FonSettingsScript self;
    public GameObject i1on;
    public GameObject i2on;
    public GameObject i3on;
    public GameObject i4on;
    public GameObject i5on;

    public GameObject i1off;
    public GameObject i2off;
    public GameObject i3off;
    public GameObject i4off;
    public GameObject i5off;


    public bool on1;
    public bool on2;
    public bool on3;
    public bool on4;
    public bool on5;


    public void ViewShops()
    {
        if (i1on.activeSelf)
        {
            i1on.SetActive(false);
            i1off.SetActive(true);
            on1 = false;   
        }
        else
        {
            i1on.SetActive(true);
            i1off.SetActive(false);
            on1 = true; 
        }
    }

    public void ViewMuseums()
    {
        if (i2on.activeSelf)
        {
            i2on.SetActive(false);
            i2off.SetActive(true);
            on2 = false;
        }
        else
        {
            i2on.SetActive(true);
            i2off.SetActive(false);
            on2 = true; 
        }

    }

    public void ViewRest()
    {
        if (i3on.activeSelf)
        {
            i3on.SetActive(false);
            i3off.SetActive(true);
            on3 = false;
        }
        else
        {
            i3on.SetActive(true);
            i3off.SetActive(false);
            on3 = true;
        }

    }

    public void ViewTours()
    {
        if (i4on.activeSelf)
        {
            i4on.SetActive(false);
            i4off.SetActive(true);
            on4 = false;
        }
        else
        {
            i4on.SetActive(true);
            i4off.SetActive(false);
            on4 = true;
        }
    }

    public void ViewBars()
    {
        if (i5on.activeSelf)
        {
            i5on.SetActive(false);
            i5off.SetActive(true);
            on5 = false;
        }
        else
        {
            i5on.SetActive(true);
            i5off.SetActive(false);
            on5 = true;
        }
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
