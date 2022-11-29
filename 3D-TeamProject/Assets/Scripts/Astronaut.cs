using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//¾È³ç
public class Astronaut : MonoBehaviour
{
	public float speed;
    static public int PlayerHp = 500;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello!!");
    }

    void Update()
    {
		// w ->¾Õ
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


