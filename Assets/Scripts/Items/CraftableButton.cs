using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftableButton : MonoBehaviour {

	[SerializeField] CraftableItem item;

	private bool isComplete = true;
	private Player player;
	private Button button;

	private void Start() {
		player = GameObject.FindObjectOfType<Player>();
		button = GetComponent<Button>();
	}

	private void Update() {
		foreach (BaseItem b in item.ConstructionTree) {
			if (!player.itemList.Contains(b)) {
				isComplete = false;
				break;
			}
			isComplete = true;
		}

		button.interactable = isComplete;
	}

	public void Craft() {
		foreach(BaseItem b in item.ConstructionTree) {
			player.itemList.RemoveAt(player.itemList.IndexOf(b));
		}
	}
}
