using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightControl : MonoBehaviour {

	public float minutesPerSecond;

    float degreesPerFrame;

    void Update () {
        degreesPerFrame = minutesPerSecond * Time.deltaTime * 360 / 1440;
        transform.Rotate(degreesPerFrame,0,0,Space.Self);
    }
}
