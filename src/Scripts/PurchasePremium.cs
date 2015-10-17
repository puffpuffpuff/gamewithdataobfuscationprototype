using UnityEngine;
using System.Collections;

public class PurchasePremium : MonoBehaviour {
	private GUISkin skin;
	
	public string textMessage = "Purchase this, 70000 point";
	
	public int widthButton = -68;

	public GUIText scoreText;

	private int point;
	private uint pointx; 
	private string message;
	
	void Start()
	{
		// Load a skin for the buttons
		skin = Resources.Load("GUISkin") as GUISkin;
	}
	
	void OnGUI()
	{
		const int buttonWidth = 168;
		const int buttonHeight = 60;
		
		// Set the skin to use
		GUI.skin = skin;
		
		// Draw a button to start the game
		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(Screen.width / 2 - widthButton, (2 * Screen.height / 3) - (buttonHeight / 2), buttonWidth, buttonHeight),
			textMessage
			))
		{
			point = PlayerPrefs.GetInt("PlayerScore");
			//without obfuscation point is 1890000 and 70000 is default
			if(point < 68521){
				message = "Not enough point";
				scoreText.text = message;
			}else{
				pointx = checked((uint)point);
				pointx = pointx ^ 47;
				pointx -= 70000;
				pointx = pointx ^ 47;
				point = checked((int)pointx);
				PlayerPrefs.SetInt("PlayerScore",point);
				//ScoreManager.score = point;
				PlayerPrefs.SetString("Premium","Donatur");
				// On Click, load the first level.
				Application.LoadLevel("Scene3a"); // "Stage1" is the scene name
			}

		}
	}
}
