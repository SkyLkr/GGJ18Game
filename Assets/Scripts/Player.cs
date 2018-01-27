using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	[SerializeField] float speed;

	public Interactable interactingObject;

	public List<Item> itemList;

	CharacterController controller;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(horizontal, 0, vertical);
		controller.Move(movement * speed * Time.deltaTime);

		if (Input.GetButtonDown("Interact")) {
			interactingObject.Interact();
		}
	}
}
