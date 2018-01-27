using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Wire", menuName="Item/Wire")]
public class Wires : Item {

    public override void Use() {
    	Debug.Log("This item is unusable right now");
    }
}
