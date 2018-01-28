using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	[SerializeField] Player player;
	[SerializeField] GameObject itemButton;

	private List<GameObject> itemsShown = new List<GameObject>();
	private RectTransform rect;

	// Use this for initialization
	void Start () {
		rect = GetComponent<RectTransform>();

		foreach (Item item in player.itemList) {
			GameObject temp = Instantiate(itemButton);
			temp.transform.SetParent(rect, false);
			if (item.icon != null) 
				temp.GetComponent<Image>().sprite = item.icon;
			temp.transform.GetChild(0).GetComponent<Text>().text = item.name;
			temp.GetComponent<ItemButton>().item = item;
			itemsShown.Add(temp);
		}
	}

	void OnEnable() {
		foreach (Item item in player.itemList) {
			GameObject temp = Instantiate(itemButton);
			temp.transform.SetParent(rect, false);
			if (item.icon != null) 
				temp.GetComponent<Image>().sprite = item.icon;
			temp.transform.GetChild(0).GetComponent<Text>().text = item.name;
			temp.GetComponent<ItemButton>().item = item;
			itemsShown.Add(temp);
		}
	}
	
	void OnDisable() {
		foreach (GameObject obj in itemsShown) {
			Destroy(obj);
		}
		itemsShown = new List<GameObject>();
	}
}
