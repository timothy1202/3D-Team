using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class item3 : MonoBehaviour
{

    public GameObject item_3;
    public bool Able3 = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Able3 == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                item_3 = GameObject.Find("Barrel_1");
                Destroy(item_3);
            }
        }
    }
    private void OnCollisionEnter(Collision coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
          Able3= true;
        }
    }
}
