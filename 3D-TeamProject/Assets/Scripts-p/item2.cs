using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class item2 : MonoBehaviour
{ 
    public GameObject item_2;
    public bool Able2 = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Able2 == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                item_2 = GameObject.Find("Barrel_1 (1)");
                Destroy(item_2);
            }
        }


    }
    private void OnCollisionEnter(Collision coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
         Able2= true;
        }
    }
}
