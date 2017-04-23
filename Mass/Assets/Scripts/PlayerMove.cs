using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	public float vertspeed, horispeed,xval,yval;

	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (transform.position.x + Time.deltaTime * Input.GetAxis ("Horizontal") * horispeed, transform.position.y + Time.deltaTime * Input.GetAxis ("Vertical") * vertspeed, 0f);

		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -xval, xval), Mathf.Clamp (transform.position.y, -yval, yval), 0f);
	}
}
