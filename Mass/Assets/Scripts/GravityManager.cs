using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour {

	// Use this for initialization

	public static Rigidbody2D[] GravityList;
	private GameObject[] GravityObjectList;
	private int i;

	void Start(){

		GravityCalc();

	}
	void Update() {
		GravityCalc();
	}
	void GravityCalc() {

		GravityObjectList = GameObject.FindGameObjectsWithTag("Gravity");

		for(i=0; i<=GravityObjectList.Length; i++)
		{
			GravityList[i] = GravityObjectList[i].GetComponent<Rigidbody2D>();

		}
			
//		foreach(GameObject GravityPart in GameObject.FindGameObjectsWithTag("Gravity")) {
//
//			GravityList.Add(GravityPart.GetComponents<Rigidbody2D>);
//		}
	}
}
