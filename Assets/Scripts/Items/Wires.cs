using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wires : IItem {

	private string name;
	private List<IItem> constructionTree;

    public string Name {
        get {
            return name;
        }
    }

    public List<IItem> ConstructionTree {
        get {
            return constructionTree;
        }
    }

    public void Use() {
    	Debug.Log("This item is unusable right now");
    }
}
