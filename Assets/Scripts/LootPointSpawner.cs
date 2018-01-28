using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPointSpawner : MonoBehaviour {

	[SerializeField] GameObject lootPoint;
	[SerializeField] int quantidade;
	[SerializeField] Transform[] spawnSpots;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < quantidade; i++) {
			Instantiate(lootPoint, spawnSpots[Random.Range(0, spawnSpots.Length)].position, lootPoint.transform.rotation);
		}
	}
}
