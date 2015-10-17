using UnityEngine;
using System.Collections;

public class XORenemy : MonoBehaviour {
	
	public int hp = 2;
	public uint scoreVal;
	private uint score;
	private uint uScore;
	public bool isEnemy = true;
	public static int check;
	//private uint obfuscate = 1 ^ 1993;
	
	void OnTriggerEnter2D (Collider2D collider) {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript>();
		
		if (shot != null){
			if(shot.isEnemyShot != isEnemy){
				hp -= shot.Damage;
				
				Destroy(shot.gameObject);
				
				if(hp <= 0){
					//XORscore.score += 27;
					//score = XORscore.score;
					scoreVal = XORscore.score;
					if(scoreVal.Equals (6873)){
						scoreVal = 6872;
						XORscore.score = scoreVal;
					}else if(scoreVal.Equals (6872)){
						scoreVal = 6875;
						XORscore.score = scoreVal;
					}else{
						uScore = scoreVal ^ 6873;
						check = checked((int)(uScore));
						if((check % 2).Equals(1)){
							uint temp = 2;
							score = (uScore + temp) ^ 6873;
							XORscore.score = (score ^ 6872) ^ 6873;
						}else{
							score = uScore ^ 6873;
							XORscore.score = ((score ^ 6872)) ^ 6873;
						}
					}

					Destroy(gameObject);

				}
			}
		}
	}
}
