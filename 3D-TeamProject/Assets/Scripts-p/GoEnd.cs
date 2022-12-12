using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoEnd : MonoBehaviour
{
    bool goEnd=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (goEnd == true)
        {
            if(Input.GetMouseButtonDown(1))
            {
                SceneManager.LoadScene("Ending");
            }
        }
    }
    private void OnCollisionEnter(Collision coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
            goEnd= true;
        }
    }

}
