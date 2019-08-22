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

public class MoreScript : MonoBehaviour
{

    public GameObject usefull_info_btn;
    public GameObject maps_btn;
    public GameObject report_btn;
    public GameObject choise_info;
    public GameObject info2;
    public GameObject choise_tour;
    public GameObject choise_restaurants;
    public GameObject fon_phones;
    public GameObject fon_settings;
    public GameObject fon_maps;
    public GameObject search;
    public GameObject back;

    private List<bool> defaultElems = new List<bool>();
    Transform[] Objs;
    public GameObject choise_shops;
    public GameObject choise_clubs;


    public static MoreScript self;
   

    
    public void UsefullInfoBtn()

    {
        info2.SetActive(false);
        report_btn.SetActive(false);
        choise_info.SetActive(true);
        fon_settings.SetActive(false);
    }

    public void MapsBtn()

    {
        info2.SetActive(false);
        report_btn.SetActive(false);
        fon_maps.SetActive(true);
        search.SetActive(true);
        StartCoroutine(enumerator());
        search.SetActive(true);
        back.SetActive(true);
    }

   IEnumerator enumerator() 
    { yield return null;

        MapScript.self.SetMap();
    }

    private void Start()
    {
        self = this;
        Objs = gameObject.GetComponentsInChildren<Transform>(true);
        foreach (Transform _val in Objs)
        {
            defaultElems.Add(_val.gameObject.activeSelf);
        }
    }

    public void SetDefault()
    {
        for ( int i = 0; i<Objs.Length; i++)
        {
            Objs[i].gameObject.SetActive(defaultElems[i]);
        }
    }

}
