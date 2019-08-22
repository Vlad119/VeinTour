using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blabla : MonoBehaviour {

    public static blabla self;
    private void Start()
    {
        self = this;
    }

    public void qq(int id)
    {
        StartCoroutine(qwe(id));
    }
    public IEnumerator qwe(int id)
    {
        yield return new WaitForSeconds(0.5f);
        ScrollSnapRect.self.SetPage(id - 1);
    }
}
