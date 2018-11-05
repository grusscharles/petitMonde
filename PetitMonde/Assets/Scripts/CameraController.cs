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
    private Vector3 initialAngles;

    void Start()
    {
        offset = transform.position - player.transform.position;
        distanceToCenter = transform.position.magnitude;
        initialAngles = transform.eulerAngles;
    }
    private void Update()
    {
        transform.position = player.transform.position + offset;
        float posMag = transform.position.magnitude;
        transform.position = (distanceToCenter / posMag) * transform.position;

        //transform.LookAt(player.transform);

        float tetaCam = Mathf.Acos(transform.position.x / transform.position.magnitude);
        float tetaPlayer = Mathf.Acos(player.transform.position.x / player.transform.position.magnitude);
        float camAngle = 0.5f * (Mathf.PI - tetaPlayer + tetaCam);

        Debug.Log("Euler Angles : " + transform.eulerAngles);
        transform.eulerAngles = new Vector3(camAngle, initialAngles.y, initialAngles.z);
        // the second argument, upwards, defaults to Vector3.up
        /*Quaternion rotation = Quaternion.LookRotation(-offset, relativeUp);
        transform.rotation.SetLookRotation(-offset,relativeUp);
        Debug.Log("relativeUp : " + relativeUp);*/
    }
}

