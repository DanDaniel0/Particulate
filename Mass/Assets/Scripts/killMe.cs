using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killMe : MonoBehaviour {

	public float xvalKILL, yvalKILL;
	private float killTime = 1f;
	private float curDeath;

	void Start()
	{
		curDeath = Time.time;
	}
	// Update is called once per frame
	void Update () {
		if (-xvalKILL < transform.position.x && transform.position.x < xvalKILL && -yvalKILL < transform.position.y && transform.position.y < yvalKILL) {
			curDeath = Time.time;
		} else {
			if (curDeath + killTime < Time.time) {
				Destroy (gameObject);
			}
		}
	}
}
