using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class GrayDotActive : MonoBehaviour
{
    protected bool PlugState;
    public GameObject PlugTarget;
    // Start is called before the first frame update
    void Start()
    {
        PlugState = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(UIMgrGrayDot.GrayDotBtOn ==true)
        {
                Debug.Log("�÷��׸� ����");
                if (PlugState == false)
                {
                    PlugTarget.SetActive(true);
                    Debug.Log("�÷��� ���ܳ�");
                    PlugState = true;
                    UIMgrGrayDot.GrayDotBtOn= false;
                }
        }
    }
}
