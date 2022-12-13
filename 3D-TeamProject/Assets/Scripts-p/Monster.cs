using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Monster : MonoBehaviour
{
    public enum MonsterState { idle, trace, attack };
    public MonsterState monsterState = MonsterState.idle;

    private Transform monsterTr;
    private Transform playerTr;
    private UnityEngine.AI.NavMeshAgent nvAgent;
    private Animator animator;
    public bool Attack=false;

    public float traceDist = 10.0f;
    public float attackDist = 2.0f;
    private bool isDie = false;

    private IEnumerator DelayedAction()
    {
        while (Attack == true)
        {
            yield return new WaitForSeconds(2.0f);
            Player.curhp = Player.curhp - 10;

            if (Player.curhp <= 0)
            {
                Astronaut.PlayerDie();
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        monsterTr = this.gameObject.GetComponent<Transform>();
        playerTr = GameObject.FindWithTag("Player").GetComponent<Transform>();
        nvAgent = this.gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = this.gameObject.GetComponent<Animator>();
        nvAgent.destination = playerTr.position;

        StartCoroutine(this.CheckMonsterState());
        StartCoroutine(this.MonsterAction());

    }

    IEnumerator CheckMonsterState()
    {
        while (!isDie)
        {
            yield return new WaitForSeconds(0.2f);

            float dist = Vector3.Distance(playerTr.position, monsterTr.position);

            if (dist <= attackDist)
            {
                monsterState = MonsterState.attack;
            }
            else if (dist <= traceDist)
            {
                monsterState = MonsterState.trace;
            }
        }
    }

    IEnumerator MonsterAction()
    {
        while (!isDie)
        {
            switch (monsterState)
            {
                case MonsterState.idle:
                    nvAgent.isStopped = true;
                    animator.SetBool("IsTrace", false);
                    break;
                case MonsterState.trace:
                    nvAgent.destination = playerTr.position;
                    nvAgent.isStopped = false;
                    animator.SetBool("IsAttack", false);
                    animator.SetBool("IsTrace", true);
                    break;
                case MonsterState.attack:
                    nvAgent.isStopped = true;
                    animator.SetBool("IsAttack", true);
                    break;
            }
            yield return null;

        }
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter(Collision coll)
    {

        if (coll.collider.CompareTag("Player"))
        {
            Attack = true;
            StopCoroutine(DelayedAction());
            StartCoroutine(DelayedAction());
            //Player.curhp -= 25;
            //Debug.Log("Ãæµ¹");
            ////Debug.Log(curhp);

        }
    }
    private void OnCollisionExit(Collision coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Attack = false;
            StopCoroutine(DelayedAction());
        }
    }


}