using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEat : MonoBehaviour {

	private GameObject EatObj, EatMe, GravObj;
	private GameObject[] EatMe2;
	private float length, curEat, dist;
	public float EatRate,EatMin,EatMax,radius,lifeTolernece;
	int obj;
	void Start () {
		curEat = Time.time + 1f;
	}
	
	// Update is called once per frame
	void Update () {

		EatMe2 = GameObject.FindGameObjectsWithTag ("Good");

		EatMe = EatMe2 [0];

		obj = 0;
		foreach (GameObject Parent in EatMe2) {
			GravObj = Parent.transform.parent.gameObject;

			dist = (Vector2.Distance (gameObject.transform.position, new Vector2 (GravObj.transform.position.x, GravObj.transform.position.y)));

			if (dist <= radius) {
				EatMe = GravObj;
				obj++;
				break;
			}

		}

		if (obj != 0) {
			length = EatMe2.Length / 5 + obj;

			if (curEat <= Time.time && ScoreSystem.lose == false) {

				ScoreSystem.curScore++; 
				EatMe.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
				EatMe.transform.position = new Vector3 (Random.Range (-1750, 1750) / 100f, Random.Range (-1000, 1000) / 100f, 0f);
				curEat = Mathf.Clamp (EatRate / length, EatMax, EatMin) + Time.time;
			}
		} else if (curEat + lifeTolernece<= Time.time && ScoreSystem.lose == false){
			ScoreSystem.lose = true;
		}
	}
}
