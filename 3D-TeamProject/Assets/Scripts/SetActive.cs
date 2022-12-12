using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    protected bool state;
    public GameObject Target;
    bool ConsoleONOFF = 0;
    // Start is called before the first frame update
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratorCtrl.AttatchGameOpen == true)
        {

            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("키 입력 받았음");

                if (state == false)
                {
                    Target.SetActive(true);
                    Debug.Log("생겨나");
                    state = true;
                    if(Input.GetMouseButtonDown(1)) 
                    {
                        ConsoleONOFF=true;
                    }
                }
            }

        }
        if (UIMgr.AttatchGameBtOn == true)
        {
            Target.SetActive(false);
            Debug.Log("사라져");
            state = false;
            UIMgr.AttatchGameBtOn = false;
        }
        if(GeneratorCtrl.AttatchGameOpen == false)
        {
            Target.SetActive(false);
            Debug.Log("사라져");
            state = false;
        }
    }
}
