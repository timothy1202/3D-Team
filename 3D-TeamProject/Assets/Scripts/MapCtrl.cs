using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCtrl : MonoBehaviour
{
    //test
    static public bool MapOpen = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
            Debug.Log("Map");
            MapOpen = true;
        }
    }
    private void OnCollisionExit(Collision coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
            MapOpen = false;
        }
    }
}
