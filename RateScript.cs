using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateScript : MonoBehaviour
{

    public void Aplic( string s)
    {
        Application.OpenURL(s);
    }

    public void Rate()
    {
            Application.OpenURL("https://itunes.apple.com/ru/app/id671889387");
    }

    public void Vk()
    {
        Application.OpenURL("https://m.vk.com/loveaustria");
    }

    public void Facebook()
    {
        Application.OpenURL("https://m.facebook.com/welovewien?__nodl&refsrc=https%3A%2F%2Fm.facebook.com%2Ffbrdr%2F274%2F124141691098459%2F&_rdr");
    }

    public void Instagramm()
    {
        Application.OpenURL("https://instagram.com/austriaday?utm_source=ig_profile_share&igshid=1a1oueqhnxccb");
    }

}
