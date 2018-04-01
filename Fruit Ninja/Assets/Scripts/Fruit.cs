using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour {


		public GameObject fruitSlicedPrefab;
		void OnTriggerEnter2D(Collider2D col)
	{
		if(col.tag == "Blade")
		{

			// this will get the direction of the z axis so when the fruit is sliced in a specific direction it will change to that direction.
			Vector3 direction = (col.transform.position - transform.position).normalized;

			// takes the direction to look at and outpouts to rotation
			Quaternion rotation = Quaternion.LookRotation(direction);

			Instantiate(fruitSlicedPrefab,transform.position, rotation);
			Destroy(gameObject);
		}
	}
}
