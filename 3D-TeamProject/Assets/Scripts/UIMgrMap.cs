using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class UIMgrMap : MonoBehaviour
{
    static public bool MapBtOn = false;

    public void MapOnClickStartBtn()
    {
        Debug.Log("Close Map");
        MapBtOn = true;
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
