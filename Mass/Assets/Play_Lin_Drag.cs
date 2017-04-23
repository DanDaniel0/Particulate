using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Lin_Drag : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (ScoreSystem.play) {
			gameObject.GetComponent<Rigidbody2D> ().drag = 10f;
		} else {
			gameObject.GetComponent<Rigidbody2D> ().drag = 5f;
		}
	}
	

}
