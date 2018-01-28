using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour {

	[SerializeField] EventSystem eventSystem;
	[SerializeField] Canvas pauseCanvas;
	[SerializeField] GameObject inventoryPanel;
	[SerializeField] GameObject itemsPanel;
	[SerializeField] GameObject craftingsPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		// foreach(KeyCode kcode in System.Enum.GetValues(typeof(KeyCode)))
     	// {
        //  if (Input.GetKeyDown(kcode))
        //      Debug.Log("KeyCode down: " + kcode);
     	// }

		Debug.Log(eventSystem.currentSelectedGameObject);
		if (eventSystem.currentSelectedGameObject == null) {
			eventSystem.SetSelectedGameObject(eventSystem.firstSelectedGameObject);
		}

		if (inventoryPanel.activeSelf) {
			if (Input.GetButtonDown("Inventory")) {
				Time.timeScale = 1;
				inventoryPanel.SetActive(false);
			}

			if (Input.GetButtonDown("R1") || Input.GetButtonDown("L1")) {
				if (itemsPanel.activeSelf) {
					itemsPanel.SetActive(false);
					craftingsPanel.SetActive(true);
				} else {
					itemsPanel.SetActive(true);
					craftingsPanel.SetActive(false);
				}
			}
		} else {
			if (Input.GetButtonDown("Inventory")) {
				Time.timeScale = 0;
				inventoryPanel.SetActive(true);
			}
		}

		if (pauseCanvas.enabled) {
			if (Input.GetButtonDown("Pause")) {
				pauseCanvas.enabled = false;	
			}

			if (Input.GetButtonDown("Select")) {
				Debug.Log("Abrir menu");
			}
		} else {
			if (Input.GetButtonDown("Pause")) {
				pauseCanvas.enabled = true;
			}
		}
	}
}
