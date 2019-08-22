using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneScript : MonoBehaviour
{
    public void phone()
    {
        Application.OpenURL("tel://" + transform.GetChild(3).GetComponent<Text>().text);
    }

    public void Phone2()
    {
        Application.OpenURL("tel://" + transform.GetChild(0).GetComponent<Text>().text);
    }

    public void mail()
    {
        Application.OpenURL("mailto:" + "info@austriaday.com" + "?subject=Email&body=");
    }
}
