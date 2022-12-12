using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using static UnityEngine.GraphicsBuffer;

public class UIMgr1 : MonoBehaviour
{
    static public bool AttatchGameBtOn1 = false;
    public void AttatchGameOnClickStartBtn1()
    {
        Debug.Log("Close Attatch Game");
        AttatchGameBtOn1 = true;
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
