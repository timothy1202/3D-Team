using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenOnCount1 : MonoBehaviour
{
    protected bool state;
    public GameObject TurnGenOn1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Onoff1.GenOn1 == 1)
            {
                    TurnGenOn1.SetActive(true);
            }
    }
}
