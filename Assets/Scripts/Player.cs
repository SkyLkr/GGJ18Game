using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	[SerializeField] float speed;
	[SerializeField] float rotationSpeed;
	[SerializeField] float gravity;

	public Interactable interactingObject;

	public List<Item> itemList;

	CharacterController controller;

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
