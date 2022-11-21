using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorCtrl : MonoBehaviour
{
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
            Debug.Log("Play");

        }
    }
}
