using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public float spawnTime, xval, yval, maxSpawned;
	public GameObject SpawnMe;
	private GameObject[] SpawnedList;
	private float lastTime=0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		SpawnedList = GameObject.FindGameObjectsWithTag ("Good");
		if (Time.time > lastTime + spawnTime*Mathf.Clamp(80f/ScoreSystem.curScore, .625f, 1f) && SpawnedList.Length< maxSpawned ){
			lastTime = Time.time;
			Instantiate (SpawnMe, new Vector3 (Random.Range (-xval * 100, xval * 100) / 100f, Random.Range (-yval * 100, yval * 100) / 100f, 0f), transform.rotation);
		}
	}
}
