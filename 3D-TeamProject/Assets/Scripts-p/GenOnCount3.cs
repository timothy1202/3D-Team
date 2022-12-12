using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenOnCount3 : MonoBehaviour
{
    protected bool state;
    public GameObject TurnGenOn3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Onoff3.GenOn3== 1)
            {
                    TurnGenOn3.SetActive(true);
            }
    }
}
