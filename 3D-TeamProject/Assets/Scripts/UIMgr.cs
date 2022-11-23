using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using static UnityEngine.GraphicsBuffer;

public class UIMgr : MonoBehaviour
{
    static public bool AttatchGameBtOn = false;
    static public bool MapBtOn = false;
    public void AttatchGameOnClickStartBtn()
    {  
        Debug.Log("Close Attatch Game");
        AttatchGameBtOn = true; 
    }
    public void MapOnClickStartBtn()
    {
        Debug.Log("Close Map");
        MapBtOn= true;

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
