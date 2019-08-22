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
public class BackScript : MonoBehaviour
{

    public GameObject back;
    public GameObject fon_settings;
    
    public void BackFromSetting()
    {
        MapScript.self.SetMap();
    }

    public void BackToInfo2()
    {
        MoreScript.self.fon_maps.SetActive(false);
        MoreScript.self.info2.SetActive(true);
        MoreScript.self.report_btn.SetActive(true);
    }

    public void BackFromUsefullInfo()
    {
        MoreScript.self.choise_info.SetActive(false);
        MoreScript.self.info2.SetActive(true);
        MoreScript.self.report_btn.SetActive(true);
    }

    public void BackFromMuseums()
    {
        MoreScript.self.choise_tour.SetActive(false);
        MoreScript.self.choise_info.SetActive(true);
        MoreScript.self.report_btn.SetActive(true);
    }

    public void BackFromRest()
    {
        MoreScript.self.choise_restaurants.SetActive(false);
        MoreScript.self.choise_info.SetActive(true);
        MoreScript.self.report_btn.SetActive(true);
    }

    public void BackFromShops()
    {
        MoreScript.self.choise_shops.SetActive(false);
        MoreScript.self.choise_info.SetActive(true);
        MoreScript.self.report_btn.SetActive(true);
    }

    public void BackFromClubs()
    {
        MoreScript.self.choise_clubs.SetActive(false);
        MoreScript.self.choise_info.SetActive(true);
        MoreScript.self.report_btn.SetActive(true);
    }

    public void BackFromPhones()
    {
        MoreScript.self.fon_phones.SetActive(false);
        MoreScript.self.choise_info.SetActive(true);
        MoreScript.self.report_btn.SetActive(true);
    }

    public void BackFromCard1()
    {
        MainScript.self.fon_card.SetActive(false);
        Debug.Log(123123123123123);

    }



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
