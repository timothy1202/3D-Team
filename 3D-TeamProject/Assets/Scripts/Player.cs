using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class Anim
{
    public AnimationClip idle;
    public AnimationClip walk;
    public AnimationClip run;
}
public class Player : MonoBehaviour
{
    [SerializeField]
    private Slider hpbar;
    private float maxhp = 100;
    public float curhp = 100;

    private Animator animator;
    private CharacterController controller;

    public Anim anim_;
    public Animation _animation;

    private float h = 0.0f;
    private float v = 0.0f;

    public float speed = 600.0f;
    public float turnSpeed = 400.0f;
    private Vector3 moveDirection = Vector3.zero;
    public float gravity = 20.0f;
    //private float v = 0.0f;


    //public int hp = 100;
    //private int initHp;
    public Image rectRy8;

    // private bool isWalk = false;
    // private bool isRun = false;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnMovement(float h, float v)
    {
        animator.SetFloat("horizontal",h);
        animator.SetFloat("vertical", v);

    }

    public void OnRun()
    {
        animator.SetTrigger("OnRun");
    }
    void Start()
    {
        //initHp = hp;
        controller = GetComponent<CharacterController>();
        //anim = gameObject.GetComponentInChildren<Animator>();
        _animation = GetComponentInChildren<Animation>();
        //_animation.clip = anim.idle;
       // _animation.Play();
    }

    void Update()
    {

        if (Input.GetKey("w"))
        {
           // anim.SetInteger("AnimationPar", 1);
        }
        else
        {
           // anim.SetInteger("AnimationPar", 0);
        }

        if (controller.isGrounded)
        {
            moveDirection = transform.forward * Input.GetAxis("Vertical") * speed;
        }

        float turn = Input.GetAxis("Horizontal");
        transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);
        controller.Move(moveDirection * Time.deltaTime);
        moveDirection.y -= gravity * Time.deltaTime;

        if(Input.GetKey("e"))
        {//발전기 4개이상이면 위치이동/ 4개안되면 이동 ㄴㄴ
            transform.position = new Vector3(-20,5,-24);
        }

        if(Input.GetKey(KeyCode.W))
        {
            animator.Play("Walk");
            animator.SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.Play("Walk");
            animator.SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            animator.Play("Walk");
            animator.SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.Play("Walk");
            animator.SetBool("isWalk", true);
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("isRun", true);
        }
        else
        {
            //animator.Play("idle");
          //  animator.SetBool("isWalk", false);
        }
       

        if (Input.GetKey(KeyCode.LeftShift))
        {
            //Debug.Log("시프트클릭");
            speed = 15.0f;
           
        }
        else
        {
            speed = 5.0f;
        }


    }
    void OnTriggerEnter(Collider coll)
    {
        
        if (coll.gameObject.tag == "MONSTER")
        {
            curhp -= 25;
           // Debug.Log("충돌");
            Debug.Log(curhp);
        }

    }

    //private void HandleHP()
   // {
       // hpbar.value = (float)curhp / (float)maxhp;
   // }
}
    
