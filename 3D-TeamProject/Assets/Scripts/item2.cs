using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject item_2;
    public float Dist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dist = Vector3.Distance(Player.transform.position, item_2.transform.position);

        if (Dist < 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                item_2 = GameObject.Find("Barrel_1");
                Destroy(item_2);
            }
        }
    }
}
