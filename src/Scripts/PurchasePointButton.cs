using UnityEngine;
using System.Collections;

public class PurchasePointButton : MonoBehaviour {

	//private int point;
	private uint point;
	public int buttonXPosA = 90;
	public int buttonXPosB = 300;
	public int buttonYPos = 190;
	void OnGUI(){
		//	Draw a button to Purchase point A
		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(buttonXPosA, buttonYPos, 160, 40), "Purchase"))
		{
			point = checked((uint)PlayerPrefs.GetInt("PlayerScore"));
			point = point ^ 47;
			//obfuscated velue
			point += checked((uint)29443);
			//original value
			//point +=29443;
			point = point ^ 47;
			PlayerPrefs.SetInt("PlayerScore",checked((int)point));
			//ScoreManager.score = point;
		}

		//	Draw a button to Purchase point B
		if (GUI.Button(
			// Center in X, 2/3 of the height in Y
			new Rect(buttonXPosB, buttonYPos, 160, 40), "Purchase"))
		{
			point = checked((uint)PlayerPrefs.GetInt("PlayerScore"));
			point = point ^ 47;
			//obfuscated value
			//point += 1476009;
			//original value
			point += checked((uint)54667);
			//point += 54667;
			point= point ^ 47;
			PlayerPrefs.SetInt("PlayerScore",checked((int)point));
			//ScoreManager.score = point;
		}

	}
}
