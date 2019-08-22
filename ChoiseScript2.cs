using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiseScript2 : MonoBehaviour
{
    public GameObject map1;
    public GameObject map2;

    public GameObject ch1_1;
    public GameObject ch1_2;

    public GameObject ch2_1;
    public GameObject ch2_2;

    public GameObject ch3_1;
    public GameObject ch3_2;

    public GameObject ch4_1;
    public GameObject ch4_2;

    public GameObject ch5_1;
    public GameObject ch5_2;

    public GameObject vrr1;
    public GameObject vrr2;


    public void ch_1(int index)
    {
        vrr1.SetActive(false);
        vrr2.SetActive(true);

        ToursScript.self.map[index].SetActive(true);
        ToursScript.self.map[index].SetActive(true);
        ToursScript.self.SetMap(index);
    }

    public void ch_2(int index)
    {
        vrr1.SetActive(true);
        vrr2.SetActive(false);
        ToursScript.self.map[index].SetActive(false);
        ToursScript.self.open[index].SetActive(true);
        //ToursScript.self.dark_fon.SetActive(true);
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
