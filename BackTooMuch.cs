using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackTooMuch : MonoBehaviour
{
    

    public void Back()
    {
        MainScript.self.fon_too_much_photo.SetActive(false);
        MainScript.self.fon_photo.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
