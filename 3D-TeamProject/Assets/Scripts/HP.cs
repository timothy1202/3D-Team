using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HP : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;

    private float maxhp = 100;
    private float curhp = 100;

    public Player player; 
    // Start is called before the first frame update
    void Start()
    {
        hpbar.value = (float)curhp / (float)maxhp;
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
        hpbar.value = (float)player.curhp / (float)maxhp;
    }
}
