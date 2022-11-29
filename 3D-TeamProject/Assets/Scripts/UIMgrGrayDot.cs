using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using static UnityEngine.GraphicsBuffer;

public class UIMgrGrayDot : MonoBehaviour
{
    static public bool GrayDotBtOn = false;

    public void GrayDotOnClickStartBtn()
    {
        Debug.Log("Dot Clicked");
        GrayDotBtOn = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
