﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePass : MonoBehaviour {

	// the score pass will be used to identify when the level requirments have been met

	// e.g if all of the enemies have been killed

	// if certain items have been obtained

	public GameObject PlayerObj; // the player will keep track of the current kill count

	public GameObject PortalObj; // when the requirments have met the portal will be active and the player will be able to travel through the portal

	public int RequiredKillCount =  0; // how many enemies the player has to kill before completing the level

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerObj.GetComponent<Player> ().Score >= RequiredKillCount) {

			PortalObj.GetComponent<Portal> ().Active = true;

		}
		
	}
}
