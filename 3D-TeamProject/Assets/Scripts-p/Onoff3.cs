using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onoff3 : MonoBehaviour
{
    protected bool state;
    public GameObject OnTarget3;
    static public int GenOn3 = 0;
    // Start is called before the first frame update
    void Start()
    {
        //rer
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratorCtrl3.AttatchGameOpen3 == true)
        {

            if (Input.GetMouseButtonDown(1))
            {
                OnTarget3.SetActive(true);
                GenOn3++;
            }

        }
    }
}
