using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour {
    [SerializeField]
    private GameObject destroyedPrefab;

    private float timeSinceDestruction =0f;

    private GameObject destroyedObject;
	// Use this for initialization
	void Start () {
        destroyedObject = null;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Debug.Log("collision");
            destroyedObject = Instantiate(destroyedPrefab, gameObject.transform.position, gameObject.transform.rotation);
            destroyedObject.transform.localScale = gameObject.transform.localScale;
            Destroy(gameObject);

            timeSinceDestruction = 0f;
        }
    }

    private void Update()
    {
        timeSinceDestruction += Time.deltaTime;

        if(timeSinceDestruction > 2f)
        {
            if(destroyedObject!= null)
            {
                Destroy(destroyedObject);
            }
            else
            {
                Debug.LogWarning("destroyed object is null");
            }
        }
    }

}
