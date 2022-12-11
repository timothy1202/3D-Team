using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anim_
{
    public AnimationClip idle;
    public AnimationClip walk;
    public AnimationClip attack;
}
public class HP : MonoBehaviour
{
   

    public enum MonsterState { idle, trace, attack };
    public Anim anim;
    private Animation _animation;

    public float traceDist = 10.0f;
    public float attackDist = 2.0f;

    [SerializeField]
    private Slider hpbar;

    private float maxhp = 100;
    private float curhp = 100;

    // Start is called before the first frame update
    void Start()
    {
        hpbar.value = (float)curhp / (float)maxhp;
    }

    // Update is called once per frame
    void Update()
    {//몬스터 추적거리 안에 들어오면 체력감소
        //_animation = GetComponent<Animation>();
        
         HandleMP();
    }

    void CollisionEnter(Collider coll)
    {
        if (coll.gameObject.tag == "MONSTER")
        {
            curhp -= 25;

            hpbar.value = (float)curhp / (float)maxhp;

           /* Debug.Log("Player HP = " + curhp.ToString());
            if (curhp <= 0)
            {
                PlayerDie();
            }*/
        }

    }

    void PlayerDie()
    {
        Debug.Log("Player Die!!");

        GameObject[] monsters = GameObject.FindGameObjectsWithTag("MONSTER");

        foreach (GameObject monster in monsters)
        {
            monster.SendMessage("OnPlayerDie", SendMessageOptions.DontRequireReceiver);
        }
    }
    private void HandleMP()
     {
         hpbar.value = (float)curhp / (float)maxhp;
     }

}


