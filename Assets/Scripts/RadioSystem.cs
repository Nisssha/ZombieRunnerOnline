using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

	private AudioSource audioSource;
	public AudioClip initialHeliCall;
	public AudioClip initialCallReply;
	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource>();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMakeInitialHeliCall () {
		audioSource.clip = initialHeliCall;
		audioSource.Play();
		Invoke ("InitialReply", initialHeliCall.length+ 1f);
	}

	void InitialReply (){
		audioSource.clip = initialCallReply;
		audioSource.Play();
		BroadcastMessage("OnDispatchHelicopter", 1f);
	}
}
