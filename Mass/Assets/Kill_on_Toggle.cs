using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kill_on_Toggle : MonoBehaviour {

	// Use this for initialization
	private bool curPlay;
	void Start () {
		curPlay = ScoreSystem.play;
	}
	
	// Update is called once per frame
	void Update () {
		if (ScoreSystem.play != curPlay) {
			Destroy (gameObject);
		}
	}
}
