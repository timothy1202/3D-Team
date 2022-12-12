using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    //public GameObject Player;
    public GameObject item_1;
    public bool Able=false;
    //public float Dist;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Dist = Vector3.Distance(Player.transform.position, item_1.transform.position);

        //if(Dist < 5)
        //{
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        item_1 = GameObject.Find("item");
        //        Destroy(item_1);
        //    }
        //}
        if (Able == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                item_1 = GameObject.Find("Barrel_1 (2)");
                Destroy(item_1);
            }
        }

    }
        private void OnCollisionEnter(Collision coll)
        {

            if (coll.collider.CompareTag("Player"))
            {
            Able= true;
                //if (Input.GetMouseButtonDown(0))
                //{
                //item_1 = GameObject.Find("Barrel_1 (2)");
                //Destroy(item_1);
                // }
            }
        }

    
    }

