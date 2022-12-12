using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;
    // Start is called before the first frame update
    void Start()
    {
        hpbar.value = Player.curhp / Player.maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        HandleHP();
    }

    /*void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "MONSTER")
        {
            curhp -= 10;
            HandleHP();
            // Debug.Log("Ãæµ¹");
            Debug.Log(curhp);
        }

    }*/

    private void HandleHP()
    {
        hpbar.value = Player.curhp / Player.maxhp;
    }
}