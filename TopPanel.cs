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

public class TopPanel : MonoBehaviour
{

    public GameObject txt_tours;
    public GameObject txt_photo;
    public GameObject txt_about;
    public GameObject txt_more;
    public GameObject txt_taxi;
    public GameObject txt_museums;
    public GameObject txt_usefull_info;
    public GameObject txt_art_history_museum;



    public GameObject back_btn;




    public static TopPanel self;
    //public GameObject top_panel;

  
    public void TxtTours()

    {
        txt_tours.SetActive(true);
    }

    public void TxtPhoto()

    {
        txt_photo.SetActive(true);
    }

    public void TxtAbout()

    {
        txt_about.SetActive(true);
    }

    public void TxtMore()

    {
        txt_more.SetActive(true);
    }

    public void TxtTaxi()

    {
        txt_taxi.SetActive(true);
    }

    public void TxtMuseums()

    {
        txt_museums.SetActive(true);
    }

    public void UsefullInfo()

    {
        txt_usefull_info.SetActive(true);
    }

    private void Start()
    {
        self=this;
    }

}
