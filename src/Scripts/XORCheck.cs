using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class XORCheck : MonoBehaviour {
	//public GUIText scoreText;
	public static int score;
	private int showPoint = 0;
	Text instruction;
	
	void Start () {
		instruction = GetComponent<Text>();
	}
	
	
	// Use Start() for initialization
	void Awake(){
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		showPoint = XORenemy.check;
		//scoreText.text = "Point: "+ showPoint.ToString();
		instruction.text = "Point: "+ showPoint.ToString();
	}
}
