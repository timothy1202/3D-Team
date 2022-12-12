using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onoff: MonoBehaviour
{
    protected bool state;
    public GameObject OnTarget;
    static public int GenOn = 0;
    // Start is called before the first frame update
    void Start()
    {
        //rer
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratorCtrl.AttatchGameOpen == true)
        {

            if (Input.GetMouseButtonDown(1))
            {
                OnTarget.SetActive(true);
                GenOn++;
            }

        }
    }
}
