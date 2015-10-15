using UnityEngine;
using System.Collections;

public class EndOfGame : MonoBehaviour {

	public GameObject Ending;
	

	void OnTriggerEnter (Collider other){

		Instantiate(Ending, transform.position, transform.rotation);
		Destroy (gameObject);


	}
}
