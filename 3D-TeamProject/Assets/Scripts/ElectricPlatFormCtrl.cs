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
        
    }
    private void OnCollisionStay(Collider coll)
    {
        if (coll.gameObject.tag == "ElectricPlatForm")
        {
            Astronaut.PlayerHp -= HitDamage;
            Debug.Log("Player HP = " + Astronaut.PlayerHp.ToString());
            if (Astronaut.PlayerHp <= 0)
            {
                Astronaut.PlayerDie();
            }
        }
    }
}

