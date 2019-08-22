using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ToursScript : MonoBehaviour
{
    public static ToursScript self;

    [SerializeField] private Transform[] targetMap;
    public GameObject[] map;
    public GameObject[] dark_fon;
    public GameObject[] open;
    public GameObject[] choise;
    public GameObject[] control;
    public GameObject[] back;
    public ScrollRect scroll;

    public void SetMap(int index)
    {

  
            gameObject.SetActive(true);
        {
            map[index].SetActive(true);
            MainScript.self.Map.transform.SetParent(targetMap[index]);
            MainScript.self.Map.GetComponent<RectTransform>().offsetMax = new Vector2(0f, 0f);
            MainScript.self.Map.GetComponent<RectTransform>().offsetMin = new Vector2(0f, 0f);
            MainScript.self.Map.GetComponent<RectTransform>().localPosition = new Vector2(0f, 0f);
            MainScript.self.Map.GetComponent<OnlineMaps>().RemoveAllMarkers();  
            MainScript.self.Map.GetComponent<OnlineMaps>().SetPositionAndZoom((float)MainScript.self.tours[index].cords.x, (float)MainScript.self.tours[index].cords.y, 17);
            MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(MainScript.self.tours[index].cords);
            try
            {
                MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(MainScript.self.tours[index].cords);
            }
            catch { StartCoroutine(imum(index)); }
        }
    }
  
    IEnumerator imum(int index)
    {
        yield return new WaitForSeconds(5f);
        MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(MainScript.self.tours[index].cords);
        Debug.Log("111");
    }


    // Use this for initialization
    void Start ()
    {
        self = this;
        MainScript.self.Map.GetComponent<OnlineMaps>().AddMarker(new Vector2(16.369989f, 48.209538f), "");
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
