using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {


		public GameObject fruitSlicedPrefab;
		public float startForce = 15f;
		
		Rigidbody2D rb;

		
		void Start()
		{
			rb = GetComponent<Rigidbody2D>();
			// adding upward force with a value of 15f
			rb.AddForce(transform.up * startForce, ForceMode2D.Impulse);
		}
		void OnTriggerEnter2D(Collider2D col)
		{
		if(col.tag == "Blade")
		{

			// this will get the direction of the z axis so when the fruit is sliced in a specific direction it will change to that direction.
			Vector3 direction = (col.transform.position - transform.position).normalized;

			// takes the direction to look at and outpouts to rotation
			Quaternion rotation = Quaternion.LookRotation(direction);

			// add a 1 to the score
			//ScoreScript.scoreValue += 1;
			


			GameObject slicedFruit = Instantiate(fruitSlicedPrefab,transform.position, rotation);
			Destroy(slicedFruit,3f);
			Destroy(gameObject);
			
		}
	}
}
