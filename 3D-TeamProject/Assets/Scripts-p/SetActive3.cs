using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SetActive3 : MonoBehaviour
{
    protected bool state;
    public GameObject Target3;
    // Start is called before the first frame update
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratorCtrl3.AttatchGameOpen3 == true)
        {

            if (Input.GetKeyDown(KeyCode.F))
            {

                if (state == false)
                {
                    Target3.SetActive(true);
                    state = true;
                }
            }

        }
       
        if(GeneratorCtrl3.AttatchGameOpen3 == false)
        {
            Target3.SetActive(false);
            state = false;
        }
    }
}
