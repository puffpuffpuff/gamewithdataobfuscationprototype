using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int Hp = 2;
	
	public bool isEnemy = true;

	int score = 0;

	void OnTriggerEnter2D (Collider2D collider) {
	
		ShotScript shot = collider.gameObject.GetComponent<ShotScript> ();

		if (shot != null){
			if (shot.isEnemyShot != isEnemy){
				Hp -= shot.Damage;

				Destroy(shot.gameObject);

				if (Hp <= 0){
					if (PlayerPrefs.HasKey("PlayerScore")){
						score = PlayerPrefs.GetInt("PlayerScore");
						score += 1;
						PlayerPrefs.SetInt("PlayerScore",score);
					}else{
						PlayerPrefs.SetInt("PlayerScore",0);
					};

					Destroy(gameObject);
				}
			}
		}
	}
}
