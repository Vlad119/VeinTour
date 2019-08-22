using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SwitchMapContent : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private ScrollRect _scroll;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Get"  + !GetComponent<OnlineMaps>());
        _scroll.vertical = !GetComponent<OnlineMaps>();
    }

}
