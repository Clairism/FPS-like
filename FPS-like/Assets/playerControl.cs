using UnityEngine;
using System.Collections;

public class playerControl : MonoBehaviour {
	
	private float speed;
	private float RotationSpeed = 2;
	private float xSpeed;
	private float ySpeed;
	
	public float jumpSpeed = 8.0f;
	public float gravity = 20.0f;
	private Vector3 moveDirection = Vector3.zero;
	
	
	void Start () {
		
		speed = 5f;
		
	}
	
	void Update () {
		xSpeed = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		ySpeed = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		
		transform.Translate(Vector3.left * -xSpeed);
		transform.Translate (Vector3.forward * ySpeed);
		
		
		transform.Rotate(0,(Input.GetAxis("Mouse X") * RotationSpeed), 0, Space.World);
		
		
		//jump
		/*
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			//moveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton("Jump"))
				moveDirection.y = jumpSpeed;
			
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}
		*/
 }
}