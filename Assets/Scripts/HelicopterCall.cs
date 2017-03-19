using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterCall : MonoBehaviour {

private bool helicopterCalled = false;
private Rigidbody rigidBody;

	void Start ()
    {
		rigidBody = GetComponent<Rigidbody>();
	}

//calling the helicopter and setting the helicopter object in the scene into motion
void OnDispatchHelicopter ()
    {
		helicopterCalled = true;
		rigidBody.velocity = new Vector3 (0,0,50f);	
	}
}
