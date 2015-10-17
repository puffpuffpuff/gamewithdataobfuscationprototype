using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public int hp = 2;
	//public int scoreVal = 1;
	public bool isEnemy = true;
	//private int score;
	//private int uScore;
	//private uint obfuscate = 1 ^ 1993;
	public uint scoreVal;
	private uint score;
	private uint uScore;
	public static int check;

	void OnTriggerEnter2D (Collider2D collider) {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript>();

		if (shot != null){
			if(shot.isEnemyShot != isEnemy){
				hp -= shot.Damage;

				Destroy(shot.gameObject);

				if(hp <= 0){
					scoreVal = ScoreManager.score;
					if(scoreVal.Equals (47)){
						scoreVal = 46;
						ScoreManager.score = scoreVal;
						score = ScoreManager.score;
					}else if(scoreVal.Equals (46)){
						scoreVal = 45;
						ScoreManager.score = scoreVal;
						score = ScoreManager.score;
					}else{
						uScore = scoreVal ^ 47;
						check = checked((int)(uScore));
						if((check % 2).Equals(1)){
							uint temp = 2;
							score = (uScore + temp) ^ 47;
							ScoreManager.score = (score ^ 46) ^ 47;
							score = ScoreManager.score;
						}else{
							score = uScore ^ 47;
							ScoreManager.score = ((score ^ 46)) ^ 47;
							score = ScoreManager.score;
						}
					}
					//Saving score using player preference
					if (PlayerPrefs.HasKey("PlayerScore")){
						//using normal calculation
						//PlayerPrefs.SetInt("PlayerScore",score);
						//using XOR calculation

						PlayerPrefs.SetInt("PlayerScore",checked((int)(score)));
					}else{
						PlayerPrefs.SetInt("PlayerScore",0);
					};

					Destroy(gameObject);
				}
			}
		}
	}
}
