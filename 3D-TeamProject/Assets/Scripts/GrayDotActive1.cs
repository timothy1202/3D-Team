using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class GrayDotActive1 : MonoBehaviour
{
    protected bool PlugState1;
    public GameObject PlugTarget1;
    // Start is called before the first frame update
    void Start()
    {
        PlugState1 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (UIMgrGrayDot1.GrayDotBtOn1 == true)
        {
            Debug.Log("�÷��׸� ����");
            if (PlugState1 == false)
            {
                PlugTarget1.SetActive(true);
                Debug.Log("�÷��� ���ܳ�");
                PlugState1 = true;
                UIMgrGrayDot1.GrayDotBtOn1 = false;
            }
        }
    }
}
