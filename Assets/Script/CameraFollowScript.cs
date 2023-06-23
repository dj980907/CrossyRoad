using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public Transform targetObject;

    public Vector3 cameraOffset;

    public float smoothFactor = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        if (targetObject == null)
        {
            transform.position = new Vector3(500, 40, 0);

            targetObject = GameObject.Find("River otter.glb").transform.GetChild(0).transform;
            cameraOffset = transform.position - targetObject.transform.position;
        }
        //cameraOffset = transform.position - targetObject.transform.position;

    }

    void Update()
    {

        if (targetObject == null)
        {
            targetObject = GameObject.Find("River otter.glb").transform.GetChild(0).transform;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (targetObject != null)
        {
            Vector3 newPosition = targetObject.transform.position + cameraOffset;
            transform.position = newPosition;
        }
        //Vector3 newPosition = targetObject.transform.position + cameraOffset;
        //transform.position = newPosition;
    }
}
