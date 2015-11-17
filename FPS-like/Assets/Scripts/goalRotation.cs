using UnityEngine;
using System.Collections;

public class goalRotation : MonoBehaviour {

	private float speed = 1f;

	
	// Update is called once per frame
	void Update () {

		gameObject.transform.Rotate (new Vector3 (0,speed, 0));
	}
}
