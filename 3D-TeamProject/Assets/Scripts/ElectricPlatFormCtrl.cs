using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class ElectricPlatFormCtrl : HitPlatForm
{

    private IEnumerator DelayedAction()
    {
        yield return new WaitForSeconds(5.0f);
        Astronaut.PlayerHp = Astronaut.PlayerHp - HitDamage;
        Debug.Log("Player HP = " + Astronaut.PlayerHp.ToString());
     
    }

    // Start is called before the first frame update
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
             StartCoroutine(DelayedAction());
            //Astronaut.PlayerHp = Astronaut.PlayerHp - HitDamage;
            //Debug.Log("Player HP = " + Astronaut.PlayerHp.ToString());
            if (Astronaut.PlayerHp <= 0)
            {
            Astronaut.PlayerDie();
            }

        }
    }
}

