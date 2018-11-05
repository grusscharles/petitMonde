using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour {
    [SerializeField]
    private GameObject destroyedPrefab;

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("collision");
            GameObject destroyedObject = Instantiate(destroyedPrefab, gameObject.transform.position, gameObject.transform.rotation);
            destroyedObject.transform.localScale = gameObject.transform.localScale;
            Destroy(gameObject);
        }
      
    }
}
