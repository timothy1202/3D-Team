using UnityEngine;
using System.Collections;

[System.Serializable]
public class Anim
{
    public AnimationClip idle;
    public AnimationClip walk;
    public AnimationClip run;
}
public class Player : MonoBehaviour
{

    private float h = 0.0f;
    private float v = 0.0f;
    private Transform tr;
    public float moveSpeed = 10.0f;
    public float rotSpeed = 100.0f;

    public Anim anim;
    private Animation _animation;
    void Start()
    {
        tr = GetComponent<Transform>();

        _animation = GetComponent<Animation>();
        _animation.clip = anim.idle;
        _animation.Play();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Debug.Log("H=" + h.ToString());
        Debug.Log("V=" + h.ToString());

        Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        //tr.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.Self);
        tr.Translate(moveDir.normalized * Time.deltaTime * moveSpeed, Space.Self);

        tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));

        Movement();
        /*if (Input.GetKey(KeyCode.LeftControl))
        {
            moveSpeed = moveSpeed * 1.5f;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("스피드");
            moveSpeed = moveSpeed * 1.5f;
        }*/

        if(moveSpeed == 15.0f)
        {
            _animation.CrossFade(anim.run.name, 0.3f);
        }
        else if(moveSpeed == 10.0f)
        {
            _animation.CrossFade(anim.walk.name, 0.3f);
        }
        else
        {
            _animation.CrossFade(anim.idle.name, 0.3f);
        }
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
           // Debug.Log("스피드");
            moveSpeed = 15.0f;
        }
        else
        {
            moveSpeed = 10.0f;
        }
    }


}