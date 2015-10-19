using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {


	void OnTriggerEnter (Collider other) {

		Application.LoadLevel("Game Over");
	
	}
}
