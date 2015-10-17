using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float damping = 1;
	public float lookAheadFactor = 3;
	public float lookAheadReturnSpeed = 0.5f;
	public float lookAheadMoveTreshold = 0.1f;

	float offsetZ;
	Vector3 lastTarfetPosition;
	Vector3 currentVelocity;
	Vector3 lookAheadPos;

	// Use this for initialization
	void Start () {
		lastTarfetPosition = target.position;
		offsetZ = (transform.position - target.position).z;
		transform.parent = null;
	}
	
	// Update is called once per frame
	void Update () {
				//only look ahead pos if accelerating or changed position
				float xMoveDelta = (target.position - lastTarfetPosition).x;

				bool updateLookAheadTarget = Mathf.Abs (xMoveDelta) > lookAheadMoveTreshold;

				if (updateLookAheadTarget) {
						lookAheadPos = lookAheadFactor * Vector3.right * Mathf.Sign (xMoveDelta);
				} else {
						lookAheadPos = Vector3.MoveTowards (lookAheadPos, Vector3.zero, Time.deltaTime * lookAheadReturnSpeed);
				}

				Vector3 aheadTargetPos = target.position + lookAheadPos + Vector3.forward * offsetZ;
				Vector3 newPos = Vector3.SmoothDamp (transform.position, aheadTargetPos, ref currentVelocity, damping);

				transform.position = newPos;

				lastTarfetPosition = target.position;
		}
}
