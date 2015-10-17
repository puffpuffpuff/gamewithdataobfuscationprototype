using UnityEngine;
using System.Collections;

public class Parallaxing : MonoBehaviour {

	public Transform[] backGround;
	private float[] parallaxScales;
	public float smoothing = 1f;

	private Transform cam;
	private Vector3 previousCamPos;

	void awake(){
		cam = Camera.main.transform;
	}

	// Use this for initialization
	void Start () {
		previousCamPos = cam.position;

		parallaxScales = new float[backGround.Length];
		for (int i = 0; i < backGround.Length; i++) {
			parallaxScales[i] = backGround[i].position.z*-1; 		
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < backGround.Length; i++) {
			float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

			float backgroundTargetPosX = backGround[i].position.x + parallax;

			Vector3 backgroundTargetPos = new Vector3 (backgroundTargetPosX, backGround[i].position.y, backGround[i].position.z);

			backGround[i].position = Vector3.Lerp(backGround[i].position, backgroundTargetPos,smoothing * Time.deltaTime);
		}

		previousCamPos = cam.position;
	}
}
