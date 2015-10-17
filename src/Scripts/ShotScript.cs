using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

	public int Damage = 1;

	public bool isEnemyShot = false;

	// Use this for initialization
	void Start () {
		Destroy (gameObject,1);
	}

}
