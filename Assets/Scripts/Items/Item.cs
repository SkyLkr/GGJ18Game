using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject {
	public string itemName;
	public List<Item> ConstructionTree;
	public virtual void Use() {}
}
