using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour {

	private Camera eyes;

	void Start() {
		eyes = gameObject.GetComponent<Camera>();
	}

	void Update () {
		if (Input.GetButton("Zoom")) {
			eyes.fieldOfView = 30f;
		}else{
			eyes.fieldOfView = 60f;
		}
	}
}
