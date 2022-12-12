using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    bool flag;
    public GameObject door;
    public GameObject Astronaut;
    public float Dist;

    // Start is called before the first frame update
    void Start()
    {
        flag = false;
    }

    // Update is called once per frame
    void Update()
    {
        Dist = Vector3.Distance(Astronaut.transform.position, door.transform.position);

        if (Dist < 5)
        {
            door.transform.position = new Vector3(9.5f, 3.91f, 0f);
            //Invoke("OnVoke", 1.0f);
        }
        else
        {
            //WaitForSeconds(1);
            door.transform.position = new Vector3(9.5f, 0f, 0f);

            // transform.position = Vector3.MoveTowards(start, destination, 1);
        }



    }

}

