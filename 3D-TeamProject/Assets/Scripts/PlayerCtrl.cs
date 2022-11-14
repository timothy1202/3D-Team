using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    static public int PlayerHp = 100;
    //private Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag == "FirePlatForm")
        {
            PlayerHp -= 20;
            Debug.Log("Player HP = " + PlayerHp.ToString());
            if (PlayerHp <= 0)
            {
                PlayerDie();
            }
        }
        if (coll.gameObject.tag == "ElectricPlatForm")
        {
            PlayerHp -= 20;
            Debug.Log("Player HP = " + PlayerHp.ToString());
            if (PlayerHp <= 0)
            {
                PlayerDie();
            }
        }
    }
    static void PlayerDie()
    {
        Debug.Log("Player Die!!");
    }
}
