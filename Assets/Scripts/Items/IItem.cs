using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem {
	string Name { get; }
	List<IItem> ConstructionTree { get; }
	void Use();
}
