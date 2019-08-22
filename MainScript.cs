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

[Serializable]
public class Museums
{
    public string top_txt;
    public Sprite img;
    public string title;
    public string text;
    public string worktime_value;
    public string phone_value;
    public string site_value;
    public Vector2 cords;
}

[Serializable]
public class Clubs
{
    public string top_txt;
    public string title;
    public Sprite img;
    public string text;
    public string worktime_value;
    public string phone_value;
    public string site_value;
    public Vector2 cords;
}

[Serializable]
public class Restaurants
{
    public string top_txt;
    public Sprite img;
    public string title;
    public string text;
    public string phone_value;
    public string site_value;
    public Vector2 cords;
}

[Serializable]
public class Shops
{
    public string top_txt;
    public Sprite img;
    public string title;
    public string text;
    public string phone_value;
    public string site_value;
    public Vector2 cords;
}

[Serializable]
public class Tours
{
    public Vector2 cords;
}



public class MainScript : MonoBehaviour
{
    public GameObject fon_tours;
    public GameObject fon_photo;
    public GameObject fon_about;
    public GameObject fon_more;
    public GameObject fon_taxi;
    public GameObject top_panel;
    public GameObject info2;
    public GameObject fon_card;
    public GameObject report_btn;
    public static MainScript self;
    public GameObject fon_rest;
    public GameObject fon_shops;
    public GameObject fon_clubs;
    public GameObject fon_too_much_photo;
    public Canvas canvas;
    public GameObject bottom_bar;
    public GameObject message;
    public Text page;

    public List<Tours> tours;
    public List<Museums> museums;
    public List<Restaurants> restaurants;
    public List<Shops> shops;
    public List<Clubs> clubs;
    public GameObject Map;


    public void AllClose()
    {
        fon_tours.SetActive(false);
        fon_taxi.SetActive(false);
        fon_more.SetActive(false);
        fon_about.SetActive(false);
        fon_photo.SetActive(false);
        fon_too_much_photo.SetActive(false);
        BottomBar.self.tour_off.SetActive(true);
        BottomBar.self.photo_off.SetActive(true);
        BottomBar.self.taxi_off.SetActive(true);
        BottomBar.self.more_off.SetActive(true);
        BottomBar.self.about_off.SetActive(true);
    }

    public void BackClose()
    {
        MainScript.self.fon_card.SetActive(false);
        TopPanel.self.txt_art_history_museum.SetActive(false);
    }
    // Use this for initialization
    void Start()
    {
        self = this;
        fon_card.SetActive(true);
        fon_tours.SetActive(true);
        fon_card.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}