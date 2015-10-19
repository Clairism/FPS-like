using UnityEngine;
using System.Collections;

public class throwIt : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<Rigidbody>().AddForce(transform.up * 0.5f);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}