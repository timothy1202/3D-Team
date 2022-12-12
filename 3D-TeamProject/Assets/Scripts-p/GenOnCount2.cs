using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenOnCount2 : MonoBehaviour
{
    protected bool state;
    public GameObject TurnGenOn2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Onoff2.GenOn2== 1)
            {
                    TurnGenOn2.SetActive(true);
            }
    }
}
