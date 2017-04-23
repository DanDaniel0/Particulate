using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerGravity : MonoBehaviour {

	// Use this for initialization
	private GameObject[] GravityObjectList;
	private GameObject GravObj;
	private int count,obj;
	private float dist,massive;
	public float massmult,baseMass,maxMass;
	private GameObject massScore;
	public Rigidbody2D rigid;
	public float radius = 3;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		massScore = GameObject.FindGameObjectWithTag("MassScore");
		GravityObjectList = GameObject.FindGameObjectsWithTag("Good");

		obj = 0;

		foreach (GameObject Parent in GravityObjectList) {
			GravObj = Parent.transform.parent.gameObject;

			dist = (Vector2.Distance (gameObject.transform.position, new Vector2 (GravObj.transform.position.x, GravObj.transform.position.y)));

			if (dist <= radius) {
				obj++;
			}

		}

//		obj = -1;
//		for(count = 0; count < GravityObjectList.Length; count++)
//		{
//			dist = (Vector2.Distance (gameObject.transform.position, new Vector2 (GravityObjectList [count].transform.position.x, GravityObjectList [count].transform.position.y)));
//
//			if (dist <= radius) {
//				obj++;
//			}
//		}
		massive = obj*massmult + baseMass;
		if (massive > maxMass) {
			massive = maxMass;
		}
		rigid.mass = massive;
		massScore.GetComponent<Text>().text = "Mass: " + (obj).ToString();
	}
}
