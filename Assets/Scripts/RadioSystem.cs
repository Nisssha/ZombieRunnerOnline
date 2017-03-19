using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

	private AudioSource audioSource;
	public AudioClip initialHeliCall;
	public AudioClip initialCallReply;

	void Start ()
    {
		audioSource = GetComponent<AudioSource>();	
	}

    //call helicopter
	void OnMakeInitialHeliCall ()
    {
		audioSource.clip = initialHeliCall;
		audioSource.Play();
		Invoke ("InitialReply", initialHeliCall.length+ 1f);
	}

    //call helicopter
	void InitialReply ()
    {
		audioSource.clip = initialCallReply;
		audioSource.Play();
		BroadcastMessage("OnDispatchHelicopter", 1f);
	}
}
