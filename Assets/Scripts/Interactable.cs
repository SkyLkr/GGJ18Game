using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Interactable : MonoBehaviour {

	[SerializeField] GameObject interactionText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Interact() {
		Debug.Log("Interagiu");
	}

	private void OnTriggerEnter(Collider other) {
		Player player = other.GetComponent<Player>();
		if (player) {
			print(other.name + " entered interaction zone");
			interactionText.SetActive(true);
			player.interactingObject = this;
		}
	}

	private void OnTriggerExit(Collider other) {
		Player player = other.GetComponent<Player>();
		if (player) {
			print(other.name + " exited interaction zone");
			interactionText.SetActive(false);
			player.interactingObject = this;
		}
	}
}
