using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenOnCount : MonoBehaviour
{
    protected bool state;
    public GameObject TurnGenOn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Onoff.GenOn == 1)
            {
                    TurnGenOn.SetActive(true);
            }
    }
}
