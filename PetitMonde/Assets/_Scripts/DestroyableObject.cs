using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour {
    [SerializeField]
    private GameObject destroyedPrefab;

    private TimeManager timeManager;

	// Use this for initialization
	void Start () {
        timeManager = GameObject.FindObjectOfType<TimeManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            timeManager.timeSinceLastDestruction = 0f;
            timeManager.checkWaste = true;
            GameObject destroyedObject = Instantiate(destroyedPrefab, gameObject.transform.position, gameObject.transform.rotation);
            destroyedObject.transform.localScale = gameObject.transform.localScale;
            Destroy(gameObject);
        }
    }

}
