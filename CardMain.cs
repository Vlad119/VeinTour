using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using InfinityCode;

public class CardMain : MonoBehaviour {
    public static CardMain self;

    public Text top_txt;
    public Image img;
    public Text title;
    public Text text;
    public Text worktime_value;
    public Text phone_value;
    public Text site_value;
    //[SerializeField] private OnlineMaps map;   
    [SerializeField] private Transform targetMap;

    public void ShowCard(int id)
    {
        top_txt.text = MainScript.self.museums[id].top_txt;
        img.sprite = MainScript.self.museums[id].img;
        title.text = MainScript.self.museums[id].title;
        text.text = MainScript.self.museums[id].text;
        worktime_value.text = MainScript.self.museums[id].worktime_value;
        phone_value.text = MainScript.self.museums[id].phone_value;
        site_value.text = MainScript.self.museums[id].site_value;
        SetMap(id);
        MainScript.self.Map.GetComponent<OnlineMaps>().SetPositionAndZoom((float)MainScript.self.museums[id].cords.x, (float)MainScript.self.museums[id].cords.y, 17);      
        MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(MainScript.self.museums[id].cords);
    }

    public void ShowRest(int id)
    {
        top_txt.text = MainScript.self.restaurants[id].top_txt;
        img.sprite = MainScript.self.restaurants[id].img;
        title.text = MainScript.self.restaurants[id].title;
        text.text = MainScript.self.restaurants[id].text;
        worktime_value.text = "";
        phone_value.text = MainScript.self.restaurants[id].phone_value;
        site_value.text = MainScript.self.restaurants[id].site_value;
        SetMap(id);
        MainScript.self.Map.GetComponent<OnlineMaps>().SetPositionAndZoom((float)MainScript.self.restaurants[id].cords.x, (float)MainScript.self.restaurants[id].cords.y, 17);
        MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(MainScript.self.restaurants[id].cords);
    }

    public void ShowClubs(int id)
    {
        top_txt.text = MainScript.self.clubs[id].top_txt;
        img.sprite = MainScript.self.clubs[id].img;
        title.text = MainScript.self.clubs[id].title;
        text.text = MainScript.self.clubs[id].text;
        worktime_value.text = MainScript.self.clubs[id].worktime_value;
        phone_value.text = MainScript.self.clubs[id].phone_value;
        site_value.text = MainScript.self.clubs[id].site_value;
        SetMap(id);
        MainScript.self.Map.GetComponent<OnlineMaps>().SetPositionAndZoom((float)MainScript.self.clubs[id].cords.x, (float)MainScript.self.clubs[id].cords.y, 17);
        MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(MainScript.self.clubs[id].cords);
    }

    public void ShowShops(int id)
    {
        top_txt.text = MainScript.self.shops[id].top_txt;
        img.sprite = MainScript.self.shops[id].img;
        title.text = MainScript.self.shops[id].title;
        text.text = MainScript.self.shops[id].text;
        worktime_value.text =""; 
        phone_value.text = MainScript.self.shops[id].phone_value;
        site_value.text = MainScript.self.shops[id].site_value;
        SetMap(id);
        MainScript.self.Map.GetComponent<OnlineMaps>().SetPositionAndZoom((float)MainScript.self.shops[id].cords.x, (float)MainScript.self.shops[id].cords.y, 17);
        MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(MainScript.self.shops[id].cords);
    }

    public void SetMap(int id)
    {
        gameObject.SetActive(true);
        MainScript.self.Map.transform.SetParent(targetMap);
        MainScript.self.Map.GetComponent<RectTransform>().localPosition = new Vector2(0f, 0f);
        MainScript.self.Map.GetComponent<OnlineMaps>().RemoveAllMarkers();
    }

    // Use this for initialization
    void Start ()
    {
        self = this;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
