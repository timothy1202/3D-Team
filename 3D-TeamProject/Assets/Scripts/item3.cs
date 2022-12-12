using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item3 : MonoBehaviour
{
    public GameObject Player;
    public GameObject item_3;
    public float Dist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dist = Vector3.Distance(Player.transform.position, item_3.transform.position);

        if (Dist < 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                item_3 = GameObject.Find("Barrel_1_Old");
                Destroy(item_3);
            }
        }
    }
}
