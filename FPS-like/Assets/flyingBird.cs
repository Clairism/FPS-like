using UnityEngine;
using System.Collections;

public class flyingBird : MonoBehaviour {

	Animator birdController;

	// Use this for initialization
	void Start () {
		birdController = GetComponent <Animator>();
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)){
			birdController.SetInteger("state",2);
		}else if (Input.GetKey (KeyCode.DownArrow)){
			birdController.SetInteger("state",4);
		}else{
			birdController.SetInteger("state",0);
		}
	
	}
}
