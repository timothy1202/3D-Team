using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveWire : MonoBehaviour
{
    protected bool state;
    public GameObject WireTarget;
    // Start is called before the first frame update
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (UIMgrWire.WireBtOn == true)
        {
            WireTarget.SetActive(true);
            state = false;
            UIMgrWire.WireBtOn = false;
        }
    }
}