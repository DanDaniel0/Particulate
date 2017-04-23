using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour {

	// Use this for initialization
	public Text score,highScore;
	public static bool lose = false;
	private bool onceLose = true;
	public static bool play = false;
	public static int curScore;
	void Start () {
		curScore = 0;
		highScore.text = "Highscore: " + (PlayerPrefs.GetInt ("Highscore",0)).ToString ();
	}
	
	// Update is called once per frame
	void Update () {

		if (!play) {
			onceLose = true;
			lose = false;
		}
		score.text = "Score: " + (curScore).ToString();

		if(curScore>PlayerPrefs.GetInt("Highscore",0)){
			PlayerPrefs.SetInt("Highscore",curScore);
			highScore.text = "Highscore: " + (curScore).ToString();
		}

		if (lose && onceLose) {
			Invoke ("MainMenu", 2f);
			onceLose = false;
			highScore.text = "";
			score.text = "";
		}
			
	}
	void MainMenu(){
		play = false;
	}
}
