using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	[SerializeField] Player player;
	[SerializeField] GameObject itemButton;

	private List<Button> itemsShown;
	private RectTransform rect;

	// Use this for initialization
	void Start () {
		rect = GetComponent<RectTransform>();

		
	}

	void OnEnable() {
		foreach (Item item in player.itemList) {
			GameObject temp = Instantiate(itemButton);
			temp.transform.SetParent(rect, false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
