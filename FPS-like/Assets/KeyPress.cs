using UnityEngine;
using System.Collections;

public class KeyPress : MonoBehaviour {

	private float rayDistance = 1f;
	//private Transform key;

	public GameObject keyPresser;


	// Use this for initialization
	void Start () {

		//key = GameObject.tag = "key";
	
	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hitInfo;

		if(Input.GetKeyDown(KeyCode.Q)){

			if ( Physics.Raycast (transform.position, transform.forward, rayDistance)){

				GameObject.FindWithTag("key").transform.position += Vector3.down * 0.2f;

				Instantiate ( keyPresser, transform.position, transform.rotation );

			}
		}

	
	}
}
