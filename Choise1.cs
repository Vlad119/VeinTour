using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choise1 : MonoBehaviour
{   
    public GameObject tour_img;
    public GameObject map_img;  

    public void ChoiseTour(int index)
    {

        map_img.SetActive(true);
        map_img.SetActive(false);
        ToursScript.self.map[index].SetActive(false);
        ToursScript.self.dark_fon[index].SetActive(true);
        ToursScript.self.control[index].SetActive(true);
    }

    public void ChoiseMap(int index)
    {
        ToursScript.self.SetMap(index);  
        map_img.SetActive(false);
        map_img.SetActive(true);
        ToursScript.self.map[index].SetActive(true);
        ToursScript.self.dark_fon[index].SetActive(false);
        
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
