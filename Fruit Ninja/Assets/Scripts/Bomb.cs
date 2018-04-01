using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour {

	public float startforce = 15f;

	public GameObject BombEffectPrefab;

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
			LifeScript.LiveValue -= 1;
		}

		if(LifeScript.LiveValue == 0)
		{
			Time.timeScale = 0;
		}

		if(col.CompareTag("Blade"))
		{
			Explode();
		}
		
	}

	void Explode()
	{

		GameObject BombEffect = Instantiate(BombEffectPrefab, transform.position, transform.rotation);
		Destroy(BombEffect,1f);
	}
	

}


