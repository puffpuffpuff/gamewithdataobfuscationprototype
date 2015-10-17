using UnityEngine;
using System.Collections;

public class BackToMainMenu : MonoBehaviour {

	public int buttonXPos = 300;
	public int buttonYPos = 190;
	// Use this for initialization
	void OnGUI () {
	
		//	Draw a button to back to main menu
		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(buttonXPos, buttonYPos, 80, 40), "Main Menu"))
		{
			Application.LoadLevel("MainMenu");
		}
	}

}
