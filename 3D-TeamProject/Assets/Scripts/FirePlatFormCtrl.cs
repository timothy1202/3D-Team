using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlatFormCtrl : HitPlatForm
{
    public float HitDist = 20.0f;
    //private Transform FirePlatFormTr;
    //private Transform playerTr;
    //float dist = Vector2.Distance(playerTr.position, FirePlatFormTr.position);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            void OnTriggerStay(Collider collision)
            {
                //if (collision.gameObject.name == "FirePlatForm")
                //{
                //    PlayerCtrl.PlayerHp -= 20;
                //}

                //if (PlayerCtrl.PlayerHp <= 0)
                //{
                //    PlayerCtrl.PlayerDie();
                //}
            }
    }
}
