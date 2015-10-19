using UnityEngine;
using System.Collections;

public class moving2 : MonoBehaviour {
	
	private float ySpeed = 1f;
	private Vector3 startPosition;
	
	void Start () {
		
		startPosition = transform.position;
		
	}
	
	void Update () {
		
		transform.position += Vector3.forward * ySpeed * Time.deltaTime;
		
		
		if (Vector3.Distance (transform.position, startPosition) > 3) {
			ySpeed *= -1;
		}
		
		if (Vector3.Distance (transform.position, startPosition) < -3) {
			ySpeed *= -1;
		}
		
	}
	
	void OnTriggerEnter(Collider other){
		Destroy (gameObject);
	}

}
