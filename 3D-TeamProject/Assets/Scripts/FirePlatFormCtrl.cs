using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FirePlatFormCtrl : HitPlatForm
{
    bool PlayerOn = false;
    
    private IEnumerator DelayedAction()
    {

        while (PlayerOn == true)
        {
            yield return new WaitForSeconds(2.0f);
            Astronaut.PlayerHp = Astronaut.PlayerHp - HitDamage;
            Debug.Log("Player HP = " + Astronaut.PlayerHp.ToString());

            if (Astronaut.PlayerHp <= 0)
            {
                Astronaut.PlayerDie();
            }
        }  

        if(PlayerOn== false)
        {

        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(2.0f);
            Astronaut.PlayerHp = Astronaut.PlayerHp - HitDamage;
            Debug.Log("Player HP = " + Astronaut.PlayerHp.ToString());
        }
        }



    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
            PlayerOn = true;
            StopCoroutine(DelayedAction());
            StartCoroutine(DelayedAction());

        }
    }
    private void OnCollisionExit(Collision coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            PlayerOn = false;   
            StopCoroutine(DelayedAction());
        }
    }

}
