using Palmmedia.ReportGenerator.Core;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    protected bool state;
    public GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        state= false;
    }

    // Update is called once per frame
    void Update()
    {
        if (GeneratorCtrl.AttatchGameOpen==true)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Ű �Է� �޾���");

                if (state == false)
                {
                    Target.SetActive(true);
                    Debug.Log("���ܳ�");
                    state = true;
                    GeneratorCtrl.AttatchGameOpen = false;
                }
            }
            
        }
            if(UIMgr.AttatchGameBtOn == true) 
            {
                Target.SetActive(false);
                Debug.Log("�����");
                state = false;
                UIMgr.AttatchGameBtOn = false;
                GeneratorCtrl.AttatchGameOpen = false;
            }
    }
}
