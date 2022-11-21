using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astronaut : MonoBehaviour
{
	public float speed;
	static public int PlayerHp = 500;

	GameObject player;
	GameObject playerEquipPoint;
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
	public void Pickup(GameObject item)
	{
		SetEquip(item, true);
	}

	void Drop()
    {
		GameObject item = playerEquipPoint.GetComponentInChildren<Rigidbody>().gameObject;
		SetEquip(item, false);

		//playerEquipPoint.transform.DetachChildren();
		//isPicking = false;

	}

	void SetEquip(GameObject item, bool isEquip)
    {
		Collider[] itemColliders = item.GetComponents<Collider>();
		Rigidbody itemRigidbody = item.GetComponent<Rigidbody>();

		foreach(Collider itemCollider in itemColliders)
        {
			itemCollider.enabled = !isEquip;
        }
		itemRigidbody.isKinematic = isEquip;
    }
	static public void PlayerDie()
	{
		Debug.Log("Player Die!!");
	}

	
}


