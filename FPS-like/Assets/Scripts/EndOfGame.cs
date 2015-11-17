using UnityEngine;
using System.Collections;

public class EndOfGame : MonoBehaviour {

	public GameObject Ending;
	private Transform gotGoal;

	void Start(){

		gotGoal = GameObject.Find ("Ending").transform;

	}
	

	void OnTriggerEnter (Collider other){

		Instantiate(Ending, gotGoal.position, transform.rotation);
		Destroy (gameObject);

		GameObject.Find ("Ending").GetComponent<AudioSource>().Play ();
		//GameObject.Find ("Win").GetComponent<MeshRenderer>().SetActive(true);
		GameObject.Find("Win").transform.position = new Vector3( -19.4f, 3.63f, -7.8f );

	}

}
