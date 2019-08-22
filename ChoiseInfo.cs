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

public class ChoiseInfo : MonoBehaviour
{

    public GameObject choise_info;

    public GameObject museums_btn;
    public GameObject restaurants_btn;
    public GameObject shops_btn;
    public GameObject clubs_btn;
    public GameObject usefull_phones_btn;
 


    public static ChoiseInfo self;
    //public GameObject top_panel;


    public void Museums()

    {
        MoreScript.self.choise_info.SetActive(false);
        MoreScript.self.choise_tour.SetActive(true);
        
    }

    public void Restaurants()

    {
        MoreScript.self.choise_info.SetActive(false);
        MoreScript.self.choise_restaurants.SetActive(true);
    }

    public void Shops()

    {
        MoreScript.self.choise_info.SetActive(false);
        MoreScript.self.choise_shops.SetActive(true);

    }

    public void Clubs()

    {
        MoreScript.self.choise_info.SetActive(false);
        MoreScript.self.choise_clubs.SetActive(true);

    }

    public void UsefullPhones()

    {
        MoreScript.self.choise_info.SetActive(false);
        MoreScript.self.fon_phones.SetActive(true);
    }

    private void Start()
    {
        self = this;
    }

}
