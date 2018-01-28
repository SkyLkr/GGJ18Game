using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	[SerializeField] float speed;
	[SerializeField] float rotationSpeed;
	[SerializeField] float gravity;
	[SerializeField] Animator animator;

	public Interactable interactingObject;

	public List<Item> itemList;

	CharacterController controller;

	private float idleTime = 0;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (!isLocalPlayer) {
			if (transform.childCount > 0) Destroy(transform.GetChild(0).gameObject);
			return;
		}

		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		float angle = -1;

		float anaogSpeed = (Mathf.Abs(horizontal) + Mathf.Abs(vertical)) * 2;

		animator.SetFloat("speed", anaogSpeed);

		if (horizontal != 0.0f || vertical != 0.0f) {
     		angle = Mathf.Atan2(vertical, -horizontal) * Mathf.Rad2Deg;
     		// Do something with the angle here.
			angle -= 90;
			Transform child = transform.GetChild(0);
			child.localEulerAngles = new Vector3(child.localEulerAngles.x, angle, child.localEulerAngles.z);
 		} else {
			idleTime += Time.deltaTime;
		}

		if (idleTime >= 10) {
			idleTime = 0;
			animator.SetTrigger("idle");
		}

		float camhorizontal = Input.GetAxis("CHorizontal");
		transform.Rotate(0, camhorizontal * rotationSpeed * Time.deltaTime, 0);

		//Vector3 movement = new Vector3(horizontal, 0, vertical);
		Vector3 movement = (transform.forward * vertical) + transform.right * horizontal;


		movement.y -= gravity;

		controller.Move(movement * speed * Time.deltaTime);

		if (Input.GetButtonDown("Interact") && interactingObject != null) {
			interactingObject.Interact(this);
		}
	}
}
