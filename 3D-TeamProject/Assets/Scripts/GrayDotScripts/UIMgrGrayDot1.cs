using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using static UnityEngine.GraphicsBuffer;

public class UIMgrGrayDot1 : MonoBehaviour
{
    static public bool GrayDotBtOn1 = false;

    public void GrayDot1OnClickStartBtn()
    {
        Debug.Log("Dot Clicked");
        GrayDotBtOn1 = true;
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
