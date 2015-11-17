using UnityEngine;
using System.Collections;

public class moving : MonoBehaviour {

	private float xSpeed = 1f;
	private Vector3 startPosition;
	private AudioSource audio;

	
	// Use this for initialization
	void Start () {

		startPosition = transform.position;
		audio = GameObject.Find ("Steps").GetComponent<AudioSource> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += Vector3.right * xSpeed * Time.deltaTime;


		if (Vector3.Distance (transform.position, startPosition) > 2) {
			xSpeed *= -1;
		}

		if (Vector3.Distance (transform.position, startPosition) < -2) {
			xSpeed *= -1;
		}
	
	}

	void OnTriggerEnter(Collider other){

		audio.Play (); 
		Destroy (gameObject);
	}
}
