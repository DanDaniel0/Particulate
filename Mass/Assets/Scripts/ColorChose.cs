using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChose : MonoBehaviour {

	private SpriteRenderer colorMe;
	private float hue,sat,val;
	void Start () {
		colorMe = gameObject.GetComponent<SpriteRenderer> ();
		GenColor();
		colorMe.color = Color.HSVToRGB(hue,sat,val);
	}
	
	// Update is called once per frame
	void GenColor () {
		hue = Random.Range(0,359f)/359f;
		while (hue > (175f / 359f) && hue < (260f / 359f)) {
					hue = Random.Range(0,359f)/359f;
		}
		sat = Random.Range(0,255)/255f;
		val = Random.Range(120,255)/255f;
	}
}
