﻿using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	
	private float speed;
	private float RotationSpeed = 1.5f;
	//private float xSpeed;
	//private float ySpeed;


	void Start () {
		
		speed = 5f;

	}
	
	void Update () {

			//xSpeed = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
			//ySpeed = Input.GetAxis ("Vertical") * speed * Time.deltaTime;
		
			//transform.Translate (Vector3.left * -xSpeed);
			//transform.Translate (Vector3.forward * ySpeed);

			transform.eulerAngles += new Vector3 (0, (Input.GetAxis ("Mouse X") * RotationSpeed), 0);
			transform.eulerAngles += new Vector3 ((Input.GetAxis ("Mouse Y") * -RotationSpeed), 0, 0);

 	}
}