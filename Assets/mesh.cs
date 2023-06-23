using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesh : MonoBehaviour
{
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
            this.transform.position += new Vector3(0f, 0f, 800f) * Time.deltaTime;
        }
        else
        {
            this.transform.position += new Vector3(0f, 0f, -800f) * Time.deltaTime;
        }

    }
}
