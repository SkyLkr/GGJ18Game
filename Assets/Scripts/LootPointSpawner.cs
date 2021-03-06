﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootPointSpawner : MonoBehaviour {

	[SerializeField] GameObject lootPoint;
	[SerializeField] int quantidade;
	[SerializeField] float intervaloEmSegundos;
	[SerializeField] Transform spawnSpots;

	// Use this for initialization
	void Start () {
		List<Transform> spots = new List<Transform>();
		for(int i = 0; i < spawnSpots.childCount; i++) {
			spots.Add(spawnSpots.GetChild(i));
		}

		StartCoroutine(Spawn(spots, quantidade, intervaloEmSegundos));
	}

	IEnumerator Spawn(List<Transform> spots, int quantidade, float time) {
		List<Transform> temp = new List<Transform>(spots);
		for (int i = 0; i < quantidade; i++) {
			int index = Random.Range(0, temp.Count);
			Instantiate(lootPoint, temp[index].position, lootPoint.transform.rotation);
			temp.RemoveAt(index);
		}
		yield return new WaitForSeconds(time);
		StartCoroutine(Spawn(spots, quantidade, time));
	}
}
