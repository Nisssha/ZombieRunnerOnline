﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {

private AudioSource innerVoice;

public AudioClip whatHappened;
public AudioClip goodArea;
	public GameObject flare;

	void Start ()
    {
		innerVoice = GetComponent<AudioSource>();
		innerVoice.clip = whatHappened;
		innerVoice.Play();
	}

    //handling finding a clear area
	void OnFoundClearArea ()
    {
		innerVoice.clip = goodArea;
		innerVoice.Play();
		Invoke ("DropFlare", 3f);
		Invoke ("CallHeli", goodArea.length + 1f);
	}

    //calling helicopter
	void CallHeli ()
    {
		SendMessageUpwards ("OnMakeInitialHeliCall");
	}

void DropFlare ()
    {
	//drop a flare
	Instantiate (flare, transform.position, transform.rotation);
    }
}
