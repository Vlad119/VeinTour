using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MapScript : MonoBehaviour
{
    public static MapScript self;
    public float timeRemaining = 1f;
    public Text markerlabel;
    [SerializeField] private Transform targetMap;

    public void Settings()
    {
        MoreScript.self.fon_settings.SetActive(true);
        MoreScript.self.fon_maps.SetActive(false);
        MoreScript.self.search.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (MainScript.self.Map.GetComponent<OnlineMaps>().GetMarkerFromScreen(Input.mousePosition) != null)
            {  timeRemaining -= Time.deltaTime;
                markerlabel.text = MainScript.self.Map.GetComponent<OnlineMaps>().GetMarkerFromScreen(Input.mousePosition).address;
                markerlabel.GetComponent<RectTransform>().position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                markerlabel.GetComponent<RectTransform>().localPosition = new Vector3(markerlabel.GetComponent<RectTransform>().localPosition.x, markerlabel.GetComponent<RectTransform>().localPosition.y+100, 0);
                markerlabel.gameObject.SetActive(true);                
            }

        }
    }
    public void SetMap()
    {
        gameObject.SetActive(true);
        MainScript.self.Map.transform.SetParent(targetMap);
        MainScript.self.Map.GetComponent<RectTransform>().offsetMax=new Vector2(0f,0f);
        MainScript.self.Map.GetComponent<RectTransform>().offsetMin=new Vector2(0f,0f);
        MainScript.self.Map.GetComponent<RectTransform>().localPosition = new Vector2(0f, 0f);
        MainScript.self.Map.GetComponent<OnlineMaps>().RemoveAllMarkers();

        if (FonSettingsScript.self.on1)
        {
            foreach (var val in MainScript.self.shops)
            {
                var m= MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(val.cords);
                m.address = val.title;

            }
        }

        if (FonSettingsScript.self.on2)
        {
            foreach (var val in MainScript.self.museums)
            {
                var m = MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(val.cords);
                m.address = val.title;
            }
        }

        if (FonSettingsScript.self.on3)
        {
            foreach (var val in MainScript.self.restaurants)
            {
                var m = MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(val.cords);
                m.address = val.title;
            }
        }

        // координаты экскурсий 
        if (FonSettingsScript.self.on4)
        {
            foreach (var val in MainScript.self.tours)
            {
                var m = MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(val.cords);
                
            }
        }

        if (FonSettingsScript.self.on5)
        {
            foreach (var val in MainScript.self.clubs)
            {
                var m = MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(val.cords);
                m.address = val.title;
            }
        }
    }


    // Use this for initialization
    void Start()
    {
        self = this;
    }


}
