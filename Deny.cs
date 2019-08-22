using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deny : MonoBehaviour
{
    public void DenyTransfer()
    {
        MainScript.self.message.SetActive(false);
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
