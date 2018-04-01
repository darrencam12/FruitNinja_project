using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

	public float startforce = 15f;

	Rigidbody2D rb;

	void Start(){
		rb = GetComponent<Rigidbody2D>();

		rb.AddForce(transform.up * startforce, ForceMode2D.Impulse);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Blade")
		{
			Destroy(gameObject);
		}
		
	}

}


