using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpawner : MonoBehaviour {

	public float xval, yval, maxSpawned;
	public GameObject SpawnMe;
	private GameObject[] SpawnedList;

	private bool oncePlayer = false;

	void Start() {
		Spawn ();
	}
	void Update(){
		if (!ScoreSystem.play && oncePlayer) {
			Spawn ();
		} else if(ScoreSystem.play){
			oncePlayer = true;
		}
	}
	public void Spawn () {
		SpawnedList = GameObject.FindGameObjectsWithTag ("Good");
		while (SpawnedList.Length< maxSpawned ){
			SpawnedList = GameObject.FindGameObjectsWithTag ("Good");
			Instantiate (SpawnMe, new Vector3 (Random.Range (-xval * 100, xval * 100) / 100f, Random.Range (-yval * 100, yval * 100) / 100f, 0f), Quaternion.identity);
		}
	}

}
