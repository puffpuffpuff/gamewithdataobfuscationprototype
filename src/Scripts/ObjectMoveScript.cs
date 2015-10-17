using UnityEngine;
using System.Collections;

public class ObjectMoveScript : MonoBehaviour {

	public Vector2 speed = new Vector2(10,10);

	public Vector2 direction = new Vector2(1,0);

	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3 (speed.x * direction.x, speed.y * direction.y, 0);

		movement *= Time.deltaTime;

		transform.Translate (movement);
	}
}
