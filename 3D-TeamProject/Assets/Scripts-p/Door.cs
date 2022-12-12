using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
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
        //Dist = Vector3.Distance(Astronaut.transform.position, door.transform.position);

        //if (Dist < 4)
        //{
        //    door.transform.position = new Vector3(-22, 7f, 0.08f);
        //    //Invoke("OnVoke", 1.0f);
        //}
        //else
        //{
        //    door.transform.position = new Vector3(-22, 4f, 0.08f);

        //    // transform.position = Vector3.MoveTowards(start, destination, 1);
        //}



    }
    private void OnCollisionEnter(Collision coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
            door.transform.position = new Vector3(-22, 7f, 0.08f);
        }
    }
    private void OnCollisionExit(Collision coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
            door.transform.position = new Vector3(-22, 4f, 0.08f);
        }
    }

}
