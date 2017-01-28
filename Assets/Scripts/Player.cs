using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

private Transform[] spawnPoints;
private Transform spawnPoint;
private GameObject spawnCollection;
public bool reSpawn = false;
public GameObject playerControler;


	void Start () {
	spawnCollection = GameObject.Find("Player Spawn Points");
	spawnPoints = spawnCollection.GetComponentsInChildren<Transform>();
	}

	void Update () {
		if (reSpawn){
		spawnPoint = spawnPoints[Random.Range(1, spawnPoints.Length)];
		Debug.Log(spawnPoint.position);
		ReSpawn();
		}
	}

void ReSpawn(){
	Instantiate(playerControler, spawnPoint, false);
	reSpawn = false;
	}

}
