using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

	private float xSpeed = 1f;
	private Transform objectPosition;
	
	// Use this for initialization
	void Start () {

		objectPosition = gameObject.transform;
	
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.position += Vector3.right * xSpeed * Time.deltaTime;

		if (objectPosition.position.x >= 3f) {
			xSpeed *= -1;
		}

		if (objectPosition.position.x <= -3f) {
			xSpeed *= -1;
		}
	
	}

	void OnTriggerEnter(Collider other){
		Destroy (gameObject);
	}
}
