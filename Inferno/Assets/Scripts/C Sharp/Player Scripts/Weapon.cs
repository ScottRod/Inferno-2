﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

	public float Damage = 10.0f;

	public float SwingSpeed = 360.0f; 

	public bool Swinging = false;

	public bool Active = true;

	string CurrentRemote; 

	// Use this for initialization
	void Start () {

		for (int i = 0; i < Input.GetJoystickNames ().Length; i++) {

			CurrentRemote = Input.GetJoystickNames () [i];

		}
		
	}

	float RadToDeg(float Radians) {

		return Radians * 180 / Mathf.PI;

	}

	float DegToRad(float Degrees) {

		return Degrees * Mathf.PI / 180;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0) && Active == true) {

			Swinging = true;

		}

		if (CurrentRemote == "Sony Computer Entertainment Wireless Controller") {

			if (Input.GetButton ("Attack PS4") && Active == true) {

				Swinging = true;

			}

		}

		if (Swinging == true) {

			transform.Rotate (SwingSpeed * Time.deltaTime, 0, 0);

			if (transform.localRotation.x > 0.75) {

				SwingSpeed = -360.0f;

			}

			if (transform.localRotation.x < 0) {

				Swinging = false;

				SwingSpeed = 360.0f;

			}

		}
		
	}
}
