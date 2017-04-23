using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {


	public Rigidbody2D rb;
	public float GravMult = 1;
	private int count = 0;
	private float dist;
	public static Rigidbody2D[] GravityList;
	private GameObject[] GravityObjectList;
	private int i;
	private int length;
	private float length2;
	private Vector3 force;
	private GameObject PlayerObject;
	private bool playerGrav;

	private Vector2 pos;

	void Start(){
		playerGrav = ScoreSystem.play;
		if (ScoreSystem.play) {
			PlayerObject = GameObject.FindGameObjectWithTag ("Player");
		}
	}
	void Update ()
	{

		GravityObjectList = GameObject.FindGameObjectsWithTag ("Gravity");

//		for(i=0; i<=GravityObjectList.Length; i++)
//		{
//			GravityList[i] = GravityObjectList[i].GetComponent<Rigidbody2D>();
//
//		}
		length = GravityObjectList.Length;

		length2 = 600f / length;


		if (length2 > 7f || !ScoreSystem.play) {
			length2 = 7f;
		}

		for (count = 0; count < length; count++) {
			
			if (length2 > Vector2.Distance (rb.position, new Vector2 (GravityObjectList [count].transform.position.x, GravityObjectList [count].transform.position.y))) {
				dist = (1f / Mathf.Pow (Vector2.Distance (rb.position, new Vector2 (GravityObjectList [count].transform.position.x, GravityObjectList [count].transform.position.y)), 2f));
				if (dist < 50f) {
					pos = new Vector2 (rb.position.x, rb.position.y) - new Vector2 (GravityObjectList [count].transform.position.x, GravityObjectList [count].transform.position.y);
					force = -GravMult * GravityObjectList [count].GetComponent<Rigidbody2D> ().mass * dist * pos;
					if (force.magnitude > 450f) {
						force = force.normalized * 450f;
					}
					rb.AddForce (force);
				}
			}
		
		}
		//now play grav

		if (playerGrav) {
			if (10f > Vector2.Distance (rb.position, new Vector2 (PlayerObject.transform.position.x, PlayerObject.transform.position.y))) {
				dist = (1f / Mathf.Pow (Vector2.Distance (rb.position, new Vector2 (PlayerObject.transform.position.x, PlayerObject.transform.position.y)), 2f));
				if (dist < 50f) {
					pos = new Vector2 (rb.position.x, rb.position.y) - new Vector2 (PlayerObject.transform.position.x, PlayerObject.transform.position.y);
					force = -GravMult * PlayerObject.GetComponent<Rigidbody2D> ().mass * dist * pos;
					if (force.magnitude > 450f) {
						force = force.normalized * 450f;
					}
					rb.AddForce (force);
				}



			}
		}
	}
}
