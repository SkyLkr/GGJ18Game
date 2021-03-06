﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Interactable : MonoBehaviour {

	public static GameObject interactionText;

	public BaseItem[] items = null;

	// Use this for initialization
	void Start () {
		if (interactionText == null) {
			interactionText = GameObject.Find("InteractionText");
			interactionText.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Interact(Player player) {
		Debug.Log("Interagiu");

		int itemAmmount = Random.Range(2, 5);
		for (int i = 0; i < itemAmmount; i++) {
			print(items.Length);
			player.itemList.Add(items[Random.Range(0, items.Length)]);
		}

		Destroy(gameObject.transform.parent.gameObject);
		interactionText.SetActive(false);
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
