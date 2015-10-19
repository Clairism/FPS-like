using UnityEngine;
using System.Collections;

public class footstepAudio : MonoBehaviour {

	private bool isPlaying = true;
	private AudioSource audio;

	void Start () {

		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if( (Input.GetMouseButton(0))  && ( isPlaying == false ) ){

			audio.Play();
			isPlaying = true;

			Invoke ("turnOn", .8f);

		}
	
	}

	void turnOn() {
		isPlaying = false;
	}
}
