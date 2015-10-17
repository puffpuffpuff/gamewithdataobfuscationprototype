using UnityEngine;
using System.Collections;

public class PremiumScene : MonoBehaviour {

	private GUISkin skin;
	
	public string textMessage = "Choose This Plane";
	
	public int widthButton = 252;
	
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
			// On Click, load the first level.
			Application.LoadLevel("Scene2a"); // "Stage1" is the scene name
		}
	}
}
