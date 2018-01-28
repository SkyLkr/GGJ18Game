using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="NewCraftableItem", menuName="Item/Craftable Item")]
public class CraftableItem : Item {

	public List<BaseItem> ConstructionTree;

	public override void Use() {

	}
}
