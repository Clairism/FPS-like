using UnityEngine;
using System.Collections;

public class rayShooter : MonoBehaviour {

	public float rayDistance = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//ray(position, direction)
		//only be seen in sceen view of playing
		//Debug.DrawRay( transform.position, transform.up * 50 );


		RaycastHit hitInfo;
		//if it hits sth
		if ( Physics.Raycast (transform.position, transform.forward, out hitInfo, rayDistance)){
			Debug.Log ("Got Ya -- " + hitInfo.collider.name);

		}

	}


	//see Gizmos all the time
	void OnDrawGizmos(){
		Gizmos.color = Color.yellow;
		Gizmos.DrawRay(transform.position, transform.forward * rayDistance);
//		Gizmos.color = Color.blue;
//		Gizmos.DrawRay(transform.position, transform.forward * 50);
//		Gizmos.DrawSphere(transform.position, 5);
//
	}


}
