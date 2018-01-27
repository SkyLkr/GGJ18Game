using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour {

	[SerializeField] IItem item;

	public void Click() {
		item.Use();
	}
}
