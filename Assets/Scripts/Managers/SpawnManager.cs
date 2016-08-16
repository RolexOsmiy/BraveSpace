using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour {
	public Transform BasicEnemy;
	public Transform StandartEnemy;
	public Transform MediumEnemy;
	public float nextSpawnTime;
	public float spawnRate_1 = 2;
	public float spawnRate_2 = 3;
	public float spawnRate_3 = 5;
	public Transform[] spawnPoints;

	void Start()
	{
		
	}

	void Update () 
	{
			nextSpawn();
	}

	void BasicSpawn()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length); 
		Instantiate (BasicEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
	void StandartSpawn()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (StandartEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
	void MediumSpawn()
	{
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (MediumEnemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}

	void nextSpawn (){
		if (nextSpawnTime < Time.time)
		{
			if (ScoreManager.score > 0) 
			{
				BasicSpawn ();
				nextSpawnTime = Time.time + spawnRate_1;
			}
			if (ScoreManager.score > 40) 
			{
				StandartSpawn ();
				nextSpawnTime = Time.time + spawnRate_2;
			}
			if (ScoreManager.score > 100) 
			{
				MediumSpawn();
				nextSpawnTime = Time.time + spawnRate_3;
			}
		}
	}
}