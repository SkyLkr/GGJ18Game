using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="NewBaseItem", menuName="Item/Base Item")]
public class BaseItem : Item {

	public override void Use() {
		Debug.Log("This is a basic item and can't be used for itself.");
	}
}
