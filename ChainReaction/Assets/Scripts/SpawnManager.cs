﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class SpawnManager : MonoBehaviour {
	// counter for how many mobs are still live
	public int mobCounter; 
	public GameObject mob1;
	public List<GameObject> mobList= new List<GameObject>();
	public float maxBoundaryX;
	public float maxBoundaryY;
	public float minBoundaryX;
	public float minBoundaryY;
	public float spawnTimer;
	// Use this for initialization
	void Start () {
		spawnTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		spawnTimer += Time.deltaTime;
		if(mobCounter < 10&& spawnTimer > 3){
			SpawnMob ();
			mobCounter++;
			spawnTimer = 0;
		}

	}
	void SpawnMob(){
		Vector3 pos = new Vector3 (Random.Range (minBoundaryX, maxBoundaryX),
		                          Random.Range (minBoundaryY, maxBoundaryY), 0);
		Instantiate (mob1, pos, Quaternion.identity);
	}
}
