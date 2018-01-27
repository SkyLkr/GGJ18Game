using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour {
	[SerializeField] Item item;

	public void Click() {
		item.Use();
	}
}
