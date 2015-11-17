using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	private float rayDistance = 8f;

	private Transform startPoint, endPoint;
	private float percentage;

	void Start () {
		percentage = 0.1f;	
	}
	
	void Update () {

		if(Input.GetMouseButton(0)){

			RaycastHit hitObject;
			
			if ( Physics.Raycast (transform.position, transform.forward, out hitObject, rayDistance) && (hitObject.collider.tag == "balloon") ){

				//transform.position = hitObject.transform.position;

				startPoint = gameObject.transform;
				endPoint = hitObject.transform;

				transform.position = Vector3.Lerp (startPoint.position, endPoint.position, percentage);


				percentage += Time.deltaTime/2;

				if (percentage >= 1) {
					percentage = 0;
					
				}

			}
		}

	}

	void OnDrawGizmos(){
		Gizmos.color = Color.yellow;
		Gizmos.DrawRay(transform.position, transform.forward * rayDistance);
	}
}
