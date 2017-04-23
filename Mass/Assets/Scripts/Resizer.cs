using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resizer : MonoBehaviour {


	public float minSize, maxSize, massScale;
	private float scale;

	void Start () {

		scale = Random.Range (minSize * 100, maxSize * 100) / 100f;
		transform.localScale = new Vector3(scale, scale, 0f);
		//gameObject.GetComponent<Rigidbody2D> ().mass = massScale * scale * scale;
	}
	

}
