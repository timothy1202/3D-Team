using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onoff2 : MonoBehaviour
{
    protected bool state;
    public GameObject OnTarget2;
    static public int GenOn2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        //rer
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratorCtrl2.AttatchGameOpen2 == true)
        {

            if (Input.GetMouseButtonDown(1))
            {
                OnTarget2.SetActive(true);
                GenOn2++;
            }

        }
    }
}
