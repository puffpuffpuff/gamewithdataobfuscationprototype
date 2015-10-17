using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	public GUIText scoreText;
	//public static int score;
	public static uint score;
	private int showPoint = 0;
//	private uint obfuscate = 1 ^ 1993;


	// Use Start() for initialization
	void Awake(){
		if (PlayerPrefs.HasKey ("PlayerScore")) {
						score = checked((uint)PlayerPrefs.GetInt ("PlayerScore"));
				} else {

			//without onfuscation
			//score = 0;
			score = 0 ^ 47;
				};
		//scoreText.text = "Score: "+ score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		//deobfuscate
		//this is used for number shift obfuscation
		//showPoint = score / 27;
		//showPoint = score;
		showPoint = checked((int)(score ^ 47));
		//show point inside the game
		scoreText.text = "Point: "+ showPoint.ToString();
	}
}
