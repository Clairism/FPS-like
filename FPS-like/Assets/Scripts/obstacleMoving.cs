﻿using UnityEngine;
using System.Collections;

public class obstacleMoving : MonoBehaviour {

	private Transform startPoint, endPoint;
	public float percentage;
	private float lower = 2;
	
	private int direction;

	void Start () {
		
		startPoint = GameObject.Find ("start1").transform;
		endPoint = GameObject.Find("end1").transform;
		
		direction = 1;
	}
	
	void Update () {
		
		transform.position = Vector3.Lerp(startPoint.position, endPoint.position, percentage);
		
		lower = Mathf.Max(lower, .000001f);
		
		percentage += Time.deltaTime/lower * direction;

		if ((percentage > 1) || (percentage < 0)){
			direction *= -1;
			percentage = Mathf.Clamp(percentage,0,1);
		}

	}
}
