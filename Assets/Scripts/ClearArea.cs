using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

private float timePassed = 0;
private bool heliCalled = false;

	void Update () {

		timePassed += Time.deltaTime;
		if (timePassed >= 3f && !heliCalled && Time.realtimeSinceStartup >= 10f){
			BroadcastMessage("OnFoundClearArea");
			Debug.Log("Clear Area");
			heliCalled = true;
		}	
	}

	void OnTriggerStay (Collider coll){
	if (coll.tag != "Player"){
		timePassed = 0f;
		}
	}
}
