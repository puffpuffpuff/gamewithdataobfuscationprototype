using UnityEngine;
using System.Collections;

public class MainMenuButton : MonoBehaviour {

	void OnGUI()
	{
		// Draw a button to start the game
		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(240, 140, 160, 40), "Start Game"))
		{
			// On Click, load the first level.
			if(PlayerPrefs.HasKey("Premium")){
				Application.LoadLevel("Scene3a");
			}else{
				Application.LoadLevel("Scene3");
			}
			
		}
		
		//	Draw a button to Purchase point
		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(240, 190, 160, 40), "Purchase Point"))
		{
			
			Application.LoadLevel("PurchasePoint");
		}
		
		//	Draw a button to Reset point
		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(240, 240, 160, 40), "Reset Point"))
		{
			ScoreManager.score = 6873;
			PlayerPrefs.SetInt("PlayerScore",6873);
		}

		//	Draw a button to Reset premium
		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(240, 290, 160, 40), "Reset Premium"))
		{
			
			PlayerPrefs.DeleteKey("Premium");
		}
	}
}
