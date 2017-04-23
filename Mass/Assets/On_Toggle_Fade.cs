using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class On_Toggle_Fade : MonoBehaviour {

	private bool curPlay;
	public Image mask;
	void Start () {
		curPlay = ScoreSystem.play;
	}

	// Update is called once per frame
	void Update () {
		if (ScoreSystem.play != curPlay) {
			mask.color = new Vector4 (mask.color.r, mask.color.g, mask.color.b, 1f);
		}
	}
}
