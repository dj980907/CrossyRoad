using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FerretScript : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    [HideInInspector]
    public bool disableRemoteTransformations = false;

    // The speed at which the object moves
    public float moveSpeed = 5f;

    // Rigidbody component reference
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        // Add RemoteTransformations script to object and set its entry
        if (!disableRemoteTransformations)
        {
            this.gameObject.AddComponent<RemoteTransformations>().entry = entry;
        }

        // Query additional data to get the name
        string value = "";
        if (entry.getAdditionalData() != null && entry.getAdditionalData().TryGetValue("name", out value))
        {
            // Set name
            this.gameObject.name = value;
        }

        Echo3DService.HologramStart();

        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    //flag for the rotation
    bool keepGoing = true;
    void Update()
    {
        //check if the z value of the object is 400 (right end of the plane)
        if (this.transform.position.z >= 400f)
        {
            //raise the flag
            keepGoing = false;

            //rotate the object
            this.transform.rotation = Quaternion.Euler(0f, 180f, 0f);

        }
        else if (this.transform.position.z <= -400f)
        {
            //raise a flag
            keepGoing = true;

            //back to normal
            this.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        //check the flag 
        if (keepGoing)
        {
            //move the object to the right
            this.transform.position += new Vector3(0f, 0f, 700f) * Time.deltaTime;
        }
        else
        {
            this.transform.position += new Vector3(0f, 0f, -700f) * Time.deltaTime;
        }

    }

}
