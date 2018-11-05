using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour {

    private float timer;
    [HideInInspector]
    public float timeSinceLastDestruction;
    [HideInInspector]
    public GameObject[] wasteArray;
    [HideInInspector]
    public bool checkWaste = false;

    // Use this for initialization
    void Start () {
        wasteArray = null;
        timer = 0f;
        timeSinceLastDestruction = 0f;
    }
	
	void Update () {
        timer += Time.deltaTime;
        timeSinceLastDestruction += Time.deltaTime;
        //Destroy Waste
        if (checkWaste)
        {
            DestroyWaste();
        }
    }

    private void DestroyWaste()
    {
        wasteArray = GameObject.FindGameObjectsWithTag("waste");

        if (timeSinceLastDestruction > 2f && wasteArray.Length != 0)
        {
            foreach (GameObject waste in wasteArray)
            {
                Destroy(waste);
                checkWaste = false;
            }
        }
    }
}
