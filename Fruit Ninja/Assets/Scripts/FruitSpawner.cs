using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour {

	// Use this for initialization

	public GameObject fruitPrefab;
	public Transform [] spawnPoints;

	public float minDelay = .1f;
	public float maxDelay = 1f;

	void Start () {
		// starting the "SpawnFruit" method
		StartCoroutine(SpawnFruit());
	}

	IEnumerator SpawnFruit()
	{
		while(true)
		{
			// creating a delay for the range between .1 of a second and 1 second
			float delay = Random.Range(minDelay, maxDelay);
			yield return new WaitForSeconds(delay);

			// giving a random range of time for fruit to spawn
			int spawnIndex = Random.Range(0, spawnPoints.Length);
			Transform spawnPoint = spawnPoints[spawnIndex];
			// spawning fruit
			GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPoint.position,spawnPoint.rotation);
			
			Destroy(spawnedFruit, 5f);


		}
	}
}
