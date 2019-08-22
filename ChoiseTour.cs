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

public class ChoiseTour : MonoBehaviour
{

    public GameObject choise_tour;

    public GameObject art_history_museum_btn;
    public GameObject albertina_gallery_btn;
    public GameObject gallery_belvedere_btn;
    public GameObject ethnological_museum_btn;
    public GameObject museum_of_natural_history_btn;
    public GameObject house_of_music_btn;
    public GameObject military_history_museum_btn;
    public GameObject sigmund_freud_museum_btn;
    public GameObject schönbrunn_palace_btn;



    public static ChoiseTour self;


    public void ArtHistoryMuseum()

    {

        MainScript.self.fon_more.SetActive(false);

      
    }

    public void AlbertinaGallery()

    {

        MoreScript.self.choise_tour.SetActive(false);

    }

    public void GalleryBelvedere()

    {

        MoreScript.self.choise_tour.SetActive(false);


    }

    public void EthnologicalMuseum()

    {
   
        MoreScript.self.choise_tour.SetActive(false);
     
    }

    public void MuseumOfNaturalHistory()

    {

        MoreScript.self.choise_tour.SetActive(false);


    }

    public void HouseOfMusic()

    {

    }

    public void MilitaryHistoryMuseum()

    {

    }

    public void SigmundFreudMuseum()

    {

    }

    public void SchönbrunnPalace()

    {

    }

    

    private void Start()
    {
        self = this;
    }

}
