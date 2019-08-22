using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OpenTour1 : MonoBehaviour
{
    public static OpenTour1 self;

    public void Open_tour(int index)
    {
        ToursScript.self.choise[index].SetActive(true);
        ToursScript.self.control[index].SetActive(true);
        ToursScript.self.back[index].SetActive(true);
        ToursScript.self.open[index].SetActive(false);
        ToursScript.self.scroll.horizontal = false;
        MainScript.self.bottom_bar.SetActive(false);
    }
}
