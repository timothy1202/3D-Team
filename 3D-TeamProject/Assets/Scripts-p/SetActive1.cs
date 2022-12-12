using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SetActive1 : MonoBehaviour
{
    protected bool state;
    public GameObject Target2_1;
    // Start is called before the first frame update
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratorCtrl1.AttatchGameOpen1 == true)
        {

            if (Input.GetKeyDown(KeyCode.F))
            {

                if (state == false)
                {
                    Target2_1.SetActive(true);
                    state = true;
                }
            }

        }
        if (UIMgr1.AttatchGameBtOn1 == true)
        {
            Target2_1.SetActive(false);

            state = false;
            UIMgr1.AttatchGameBtOn1 = false;
        }
        if(GeneratorCtrl1.AttatchGameOpen1 == false)
        {
            Target2_1.SetActive(false);
            state = false;
        }
    }
}
