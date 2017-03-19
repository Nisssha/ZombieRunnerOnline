using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearArea : MonoBehaviour {

private float timePassed = 0;
private bool heliCalled = false;

    //Searching for clear area
	void Update ()
    {
        //Adding time to time passed
		timePassed += Time.deltaTime;
        //if time passed in clear area is bigger than 3 and from start of the game than 10 and helicopter not called
        //call for the helicopter
		if (timePassed >= 3f && !heliCalled && Time.realtimeSinceStartup >= 10f)
        {
			BroadcastMessage("OnFoundClearArea");
			heliCalled = true;
		}	
	}

    //when staying inside collider setting time of being in clear area to zero
	void OnTriggerStay (Collider coll)
    {
	if (coll.tag != "Player")
        {
		timePassed = 0f;
		}
	}
}
