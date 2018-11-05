using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    private List<Transform> spawnPointsList;

	// Use this for initialization
	void Start () {
        spawnPointsList = new List<Transform>();
        //Initialize List
        for (int i = 0; i < transform.childCount; i++)
        {
            spawnPointsList.Add(transform.GetChild(i));
        }

        SpawnVictory();
        SpawnPlayer();

    }

    private void SpawnVictory()
    {
        int spawnIndex = Random.Range(1,7);

        //GameObject victorySpawnPawn = transform.
    }

    private void SpawnPlayer()
    {
        Debug.Log("hey");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
