using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackScript1 : MonoBehaviour
{

    public void Back(int index)
    {
        ToursScript.self.open[index].SetActive(true);
        ToursScript.self.choise[index].SetActive(false);
        ToursScript.self.control[index].SetActive(false);
        ToursScript.self.back[index].SetActive(false);
        ToursScript.self.dark_fon[index].SetActive(true);
        ToursScript.self.map[index].SetActive(false);
        ToursScript.self.scroll.horizontal = true;
        AudioScript.self.MusicSource.Pause();
        AudioScript.self.pl.SetActive(true);
        AudioScript.self.pa.SetActive(false);
        MainScript.self.bottom_bar.SetActive(true);
    }

}

