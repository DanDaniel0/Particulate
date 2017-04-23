using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayEnable : MonoBehaviour {

	public bool visablePlay;
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (ScoreSystem.play == visablePlay) {
			gameObject.GetComponent<Text>().enabled = true;
		} else {
			gameObject.GetComponent<Text>().enabled = false;
		}
	}
}
