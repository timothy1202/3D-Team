using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricPlatFormCtrl : HitPlatForm
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerStay(Collider collision)
        {
            //if (collision.gameObject.name == "ElectricPlatForm")
            //{
            //    PlayerCtrl.PlayerHp -= 20;
            //}

            //if (PlayerCtrl.PlayerHp <= 0)
            //{
            //    PlayerDie();
            //}
        }
    }
}
