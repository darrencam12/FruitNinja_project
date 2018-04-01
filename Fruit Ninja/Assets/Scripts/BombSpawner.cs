using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSpawner : MonoBehaviour {

	
	public GameObject bombPrefab;

	public Transform[] BombSpawnPoints;

	public float minBombDelay = .1f;
	public float maxBombDelay = 10f; 

	void Start () {
		// starting the "Spawnbombs" method
		StartCoroutine(Spawnbombs());
	}
	IEnumerator Spawnbombs()
	{
		while(true)
		{
			// creating a delay for the range between .1 of a second and 10 seconds
			float bombDealy = Random.Range(minBombDelay, maxBombDelay);
			yield return new WaitForSeconds(bombDealy);
			
			// giving a random range of time for bombs to spawn
			int spawnIndex = Random.Range(0, BombSpawnPoints.Length);
			Transform BombSpawnPoint = BombSpawnPoints[spawnIndex];
			// spawning bombs
			GameObject spawnedBombs= Instantiate(bombPrefab, BombSpawnPoint.position,BombSpawnPoint.rotation);
			Destroy(spawnedBombs,5f);
		}
	}
}
