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

public class ViewPhotos : MonoBehaviour
{

    public void BtnTours()
    {
        MainScript.self.AllClose();
        MainScript.self.fon_tours.SetActive(true);
    }

    public void BtnPhoto()
    {
        MainScript.self.AllClose();
        MainScript.self.fon_photo.SetActive(true);
    }

    public void BtnAbout()
    {
        MainScript.self.AllClose();
        MainScript.self.fon_about.SetActive(true);
    }

    public void BtnMore()
    {

        MainScript.self.AllClose();
        MainScript.self.fon_more.SetActive(true);
        MainScript.self.info2.SetActive(true);
        MainScript.self.report_btn.SetActive(true);
        if (MoreScript.self) MoreScript.self.SetDefault();
        MainScript.self.fon_card.SetActive(false);
        MainScript.self.fon_rest.SetActive(false);
        MainScript.self.fon_shops.SetActive(false);
        MainScript.self.fon_clubs.SetActive(false);
    }

    public void BtnTaxi()
    {
        MainScript.self.AllClose();
        MainScript.self.fon_taxi.SetActive(true);

    }

}
