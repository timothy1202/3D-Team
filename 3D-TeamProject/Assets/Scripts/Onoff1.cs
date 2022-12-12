using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onoff1 : MonoBehaviour
{
    protected bool state;
    public GameObject OnTarget1;
    static public int GenOn1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        //rer
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratorCtrl1.AttatchGameOpen1 == true)
        {

            if (Input.GetMouseButtonDown(1))
            {
                OnTarget1.SetActive(true);
                GenOn1++;
            }

        }
    }
}
