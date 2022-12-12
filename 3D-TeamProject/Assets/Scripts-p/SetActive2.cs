using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SetActive2 : MonoBehaviour
{
    protected bool state;
    public GameObject Target2;
    // Start is called before the first frame update
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratorCtrl2.AttatchGameOpen2 == true)
        {

            if (Input.GetKeyDown(KeyCode.F))
            {

                if (state == false)
                {
                    Target2.SetActive(true);
                    state = true;
                }
            }

        }
        if (UIMgr2.AttatchGameBtOn2 == true)
        {
            Target2.SetActive(false);

            state = false;
            UIMgr2.AttatchGameBtOn2 = false;
        }
        if(GeneratorCtrl2.AttatchGameOpen2 == false)
        {
            Target2.SetActive(false);
            state = false;
        }
    }
}
