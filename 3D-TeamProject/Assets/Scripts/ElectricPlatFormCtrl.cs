using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class ElectricPlatFormCtrl : HitPlatForm
{
    bool PlayerOn = false;
    private IEnumerator DelayedAction()
    {
        Debug.Log("test1");
        while(PlayerOn == true)
        {
        yield return new WaitForSeconds(2.0f);
        Astronaut.PlayerHp = Astronaut.PlayerHp - HitDamage;
        Debug.Log("Player HP = " + Astronaut.PlayerHp.ToString());

            if (Astronaut.PlayerHp <= 0)
            {
                Astronaut.PlayerDie();
            }
        }

     
    }

    // Start is called before the first frame update
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
            PlayerOn= true;
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

