using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEvil : MonoBehaviour {

	public float spawnTime, xval,xvalKILL, yval,yvalKILL, minVel, maxVel;
	public GameObject SpawnMe;
	private float lastTime=0;
	private GameObject EatBaby;
	private float spawntimer;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		spawntimer = spawnTime * (100f / ScoreSystem.curScore);
		if (spawntimer > .2f) {
			spawntimer = .2f;
		}

		if (Time.time > lastTime + spawntimer) {
			lastTime = Time.time;
			EatBaby = Instantiate (SpawnMe, new Vector3 (Random.Range(-xval * 100, xval * 100) / 100f, Random.Range(-yval * 100, yval * 100) / 100f, 0f), transform.rotation);
			EatBaby.GetComponent<Rigidbody2D>().velocity = (new Vector2(Random.Range (-maxVel * 100, maxVel * 100) / 100f, Random.Range (-maxVel * 100, maxVel * 100) / 100f));
			if (EatBaby.GetComponent<Rigidbody2D> ().velocity.magnitude < minVel || (-xvalKILL<EatBaby.transform.position.x && EatBaby.transform.position.x<xvalKILL && -yvalKILL<EatBaby.transform.position.y && EatBaby.transform.position.y<yvalKILL)) {
				Destroy (EatBaby);
			}
		}
	}
}
