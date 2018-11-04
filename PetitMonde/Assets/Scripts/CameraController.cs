using UnityEngine;
using System.Collections;
public class CameraController : MonoBehaviour
{
    [SerializeField]
    private GameObject attractor;
    [SerializeField]
    private GameObject player;

    private float distanceToCenter;
    
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
        distanceToCenter = transform.position.magnitude;
    }
    private void Update()
    {
        transform.position = player.transform.position + offset;
        float posMag = transform.position.magnitude;
        transform.position = (distanceToCenter / posMag) * transform.position;

        transform.LookAt(player.transform);
      
    }
}

