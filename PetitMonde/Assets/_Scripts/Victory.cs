using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            WinGame();
        }
    }

    void WinGame()
    {
        Debug.Log("You Win !");
        Time.timeScale = 0f;
    }
}
