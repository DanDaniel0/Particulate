using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Play : MonoBehaviour {

	public GameObject gamecontain;
	void Update () {
		if (!ScoreSystem.play && Input.anyKeyDown) {
			ScoreSystem.play = true;
			Invoke ("SpawnGame", 1.5f);
		}
		
	}
	void SpawnGame(){
		Instantiate (gamecontain, Vector3.zero, transform.rotation);
	}
}
