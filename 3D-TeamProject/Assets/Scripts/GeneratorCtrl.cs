using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class GeneratorCtrl : MonoBehaviour
{
    static public bool AttatchGameOpen = false;
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
            AttatchGameOpen = true;
        }
    }
    private void OnCollisionExit(Collision coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
            AttatchGameOpen = false;
        }
    }
}
