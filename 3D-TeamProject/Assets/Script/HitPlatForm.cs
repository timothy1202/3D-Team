using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HitPlatForm : MonoBehaviour
{
    private int HitDamage = 20;
    // Start is called before the first frame update
    void Start()
    {
        Player call =GameObject.Find(Jack).GetComponent<Player>();
        call.PlayerHp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        void OnTriggerStay(Collider collision)
        {
            if(collision.gameObject.name == "Sphere")
            {
                call.PlayerHp -= 20;
            }

            if (PlayerHp <= 0)
            {
                PlayerDie();
            }
        }
    }
}
