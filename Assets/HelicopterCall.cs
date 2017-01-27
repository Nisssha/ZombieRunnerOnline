using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterCall : MonoBehaviour {

public AudioClip hellicopterSound;
private AudioSource audioSource;
private bool helicopterCalled = false;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("CallHeli") && !helicopterCalled) {
			audioSource.clip = hellicopterSound;
			audioSource.Play();
			helicopterCalled = true;
		}
	}
}
