﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    [Header("Score Values")]
    [HideInInspector]
    public float destructionScore;
    [SerializeField]
    private float maxDestruction = 500f;

    [Header("UI Score")]
    [SerializeField]
    private Image scoreJauge;

    // Use this for initialization
    void Start () {
        destructionScore = 0f;
        scoreJauge.fillAmount = 0f;
	}

    public void UpdateScore(float buildingScore)
    {
        destructionScore += buildingScore;
        scoreJauge.fillAmount = destructionScore / maxDestruction ;
    }
	// Update is called once per frame
	void LateUpdate () {
		if(destructionScore == maxDestruction)
        {
            Debug.Log("You Suck");
        }
	}
}
