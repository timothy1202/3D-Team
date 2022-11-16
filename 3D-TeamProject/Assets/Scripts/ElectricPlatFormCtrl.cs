using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricPlatFormCtrl : HitPlatForm
{
    //private float fDestroyTime = 10f;
    //private float fTickTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //fTickTime += Time.deltaTime;

        //if (fTickTime >= fDestroyTime)
        //{
        //    // 2초 뒤에 실행
        //}
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

