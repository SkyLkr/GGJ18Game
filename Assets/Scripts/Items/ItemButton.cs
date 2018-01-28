using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour {
	[SerializeField] public Item item;

	public void Click() {
		item.Use();
	}
}
