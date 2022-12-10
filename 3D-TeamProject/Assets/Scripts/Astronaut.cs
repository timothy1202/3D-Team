using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*public class Anim
{
	public AnimationClip idle;
	public AnimationClip walk;
	public AnimationClip Jump_loop;
}*/

public class Astronaut : MonoBehaviour
{
	[SerializeField]

	private bool isRun = false;

	private Rigidbody Rigid;

	public Animation anim;
	public AnimationClip clip;

	public float speed = 10f;
	static public int PlayerHp = 500;
		
		// Start is called before the first frame update
	void Start()
	{
		Debug.Log("Hello!!");
		anim = GetComponentInChildren<Animation>();
		Rigid = GetComponent<Rigidbody>();

		
	}

	void Update()
	{
		 void run()
		 {
			isRun = true;
 
		 }
		if (Input.GetMouseButtonDown(1))
		{
			run();
			Debug.Log("스피드");
			speed = speed * 1.6f;
			
		}
		// w ->앞
		if (Input.GetKey(KeyCode.D))
		{

			transform.Translate(Vector2.right * speed);

		}

		if (Input.GetKey(KeyCode.A))
		{

			transform.Translate(-Vector2.right * speed);

		}

		if (Input.GetKey(KeyCode.W))
		{

			transform.Translate(Vector2.up * speed);

		}

		if (Input.GetKey(KeyCode.S))
		{

			transform.Translate(-Vector2.up * speed);
		}

		
	}

	static public void PlayerDie()
	{
		Debug.Log("Player Die!!");
	}

	
}


