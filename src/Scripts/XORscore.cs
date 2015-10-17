using UnityEngine;
using System.Collections;

public class XORscore : MonoBehaviour {
	
	public GUIText scoreText;
	public static uint score;
	private int showPoint = 0;
	//	private uint obfuscate = 1 ^ 1993;
	
	
	// Use Start() for initialization
	void Awake(){
			score = 0 ^ 6873;
	}
	
	// Update is called once per frame
	void Update () {
		showPoint = checked((int)(score ^ 6873));
		scoreText.text = "Point: "+ showPoint.ToString();
	}
}
