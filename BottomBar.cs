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

public class BottomBar : MonoBehaviour
    {
    public GameObject tour_on;
    public GameObject tour_off;
    public GameObject photo_on;
    public GameObject photo_off;
    public GameObject more_on;
    public GameObject more_off;
    public GameObject about_on;
    public GameObject about_off;
    public GameObject taxi_on;
    public GameObject taxi_off;

    public void BtnTours()
    {
        MainScript.self.AllClose();
        MainScript.self.fon_tours.SetActive(true);
        tour_off.SetActive(false);
    }

    public void BtnPhoto()
    {
        MainScript.self.AllClose();
        MainScript.self.fon_photo.SetActive(true);
        photo_off.SetActive(false);
    }

    public void BtnAbout()
    {
        MainScript.self.AllClose();
        MainScript.self.fon_about.SetActive(true);
        about_off.SetActive(false);
    }

    public void BtnMore()
    {
        
        MainScript.self.AllClose();
        MainScript.self.fon_more.SetActive(true);       
        MainScript.self.info2.SetActive(true);
        MainScript.self.report_btn.SetActive(true);
        if(MoreScript.self) MoreScript.self.SetDefault();
        MainScript.self.fon_card.SetActive(false);
     
        more_off.SetActive(false);
    }

    public void BtnTaxi()
    {
        MainScript.self.AllClose();
        MainScript.self.fon_taxi.SetActive(true);
        taxi_off.SetActive(false);
    }

    public int jj;
    public static BottomBar self;
    public void i1()
    {
        MainScript.self.AllClose();
        MainScript.self.fon_too_much_photo.SetActive(true);
    }

    private void Start()
    {
        self = this;
    }
}
