using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public Vector2 speed = new Vector2(50,50);
	// Update is called once per frame
	void Update () {

		float inputX = Input.GetAxis ("Horizontal");
		float inputY = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (speed.x * inputX, speed.y * inputY, 0);

		movement *= Time.deltaTime;

		transform.Translate (movement);

		bool fireWeapon = Input.GetButtonDown ("Fire1");
		fireWeapon |= Input.GetButtonDown ("Fire2");

		if (fireWeapon){
			WeaponScript weapon = GetComponent<WeaponScript>();
			if (weapon != null){
				weapon.Attack(false);
			}
		}

		// 6 - Make sure we are not outside the camera bounds
		var dist = (transform.position - Camera.main.transform.position).z;
		
		var leftBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 0, dist)
			).x;
		
		var rightBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(1, 0, dist)
			).x;
		
		var topBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 0, dist)
			).y;
		
		var bottomBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 1, dist)
			).y;
		
		transform.position = new Vector3(
			Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
			Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
			transform.position.z
			);
		
		// End of the update method
	}
}
