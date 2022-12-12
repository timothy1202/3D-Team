using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePlatFormCtrl : HitPlatForm
{
    public float HitDist = 20.0f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision coll)
    {
        if (coll.collider.tag == "Player")
        {
            Astronaut.PlayerHp = Astronaut.PlayerHp - HitDamage;
            Debug.Log("Player HP = " + Astronaut.PlayerHp.ToString());
            if (Astronaut.PlayerHp <= 0)
            {
                Astronaut.PlayerDie();
            }
        }
    }

}
