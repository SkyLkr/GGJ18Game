using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPointSpawner : MonoBehaviour {

	[SerializeField] GameObject lootPoint;
	[SerializeField] int quantidade;
	[SerializeField] Transform spawnSpots;

	// Use this for initialization
	void Start () {
		List<Transform> spots = new List<Transform>();
		for(int i = 0; i < spawnSpots.childCount; i++) {
			spots.Add(spawnSpots.GetChild(i));
		}

		for (int i = 0; i < quantidade; i++) {
			int index = Random.Range(0, spots.Count);
			Instantiate(lootPoint, spots[index].position, lootPoint.transform.rotation);
			spots.RemoveAt(index);
		}
	}
}
