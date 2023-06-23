/**************************************************************************
* Copyright (C) echoAR, Inc. (dba "echo3D") 2018-2021.                    *
* echoAR, Inc. proprietary and confidential.                              *
*                                                                         *
* Use subject to the terms of the Terms of Service available at           *
* https://www.echo3D.co/terms, or another agreement                       *
* between echoAR, Inc. and you, your company or other organization.       *
***************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehaviour : MonoBehaviour
{
    [HideInInspector]
    public Entry entry;

    [HideInInspector]
    public bool disableRemoteTransformations = false;


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

    }

    // Update is called once per frame
    bool GoatKeepGoing = true;
    bool BisonKeepGoing = true;
    bool FerretKeepGoing = true;

    int realLoadCount = 0;
    int ScriptLoadCount = 0;

    void Update()
    {
        //this is the script for River otter
        if (gameObject.name == "River otter.glb")
        {
            //set the tag
            gameObject.tag = "Player";

            //// Check if the object has a BoxCollider component
            //BoxCollider boxCollider1 = this.gameObject.GetComponent<BoxCollider>();

            //// If the BoxCollider component doesn't exist, add it
            //if (boxCollider1 == null)
            //{
            //    boxCollider1 = this.gameObject.AddComponent<BoxCollider>();
            //    boxCollider1.providesContacts = true;
            //}

            ////check if the object has a rigid body component
            //Rigidbody gameObjectsRigidBody1 = this.gameObject.GetComponent<Rigidbody>();

            //// If the BoxCollider component doesn't exist, add it
            //if (gameObjectsRigidBody1 == null)
            //{
            //    gameObjectsRigidBody1 = this.gameObject.AddComponent<Rigidbody>();
            //    gameObjectsRigidBody1.mass = 5;
            //    gameObjectsRigidBody1.collisionDetectionMode = CollisionDetectionMode.Continuous;
            //}

            //see if there is collision detection script
            CollisionDetect collisionDetect1 = this.gameObject.GetComponent<CollisionDetect>();

            //if not, then add the script component
            if (collisionDetect1 == null)
            {
                if (realLoadCount < 1)
                {
                    realLoadCount++;
                    collisionDetect1 = this.gameObject.AddComponent<CollisionDetect>();
                }

            }

            if (transform.childCount > 0)
            {
                //set the tag
                gameObject.transform.GetChild(0).tag = "Player";

                //moving the object with the left key
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    this.transform.GetChild(0).transform.Translate(new Vector3(-200f, 0f, 0f) * Time.deltaTime, Space.World);
                }
                else if (Input.GetKey(KeyCode.DownArrow))
                {
                    this.transform.GetChild(0).transform.Translate(new Vector3(200f, 0f, 0f) * Time.deltaTime, Space.World);
                }
                else if (Input.GetKey(KeyCode.LeftArrow))
                {
                    this.transform.GetChild(0).transform.Translate(new Vector3(0f, 0f, -200f) * Time.deltaTime, Space.World);
                }
                else if (Input.GetKey(KeyCode.RightArrow))
                {
                    this.transform.GetChild(0).transform.Translate(new Vector3(0f, 0f, 200f) * Time.deltaTime, Space.World);
                }

                //check if the object has a rigid body component
                Rigidbody gameObjectsRigidBody = this.transform.GetChild(0).gameObject.GetComponent<Rigidbody>();

                // If the BoxCollider component doesn't exist, add it
                if (gameObjectsRigidBody == null)
                {
                    gameObjectsRigidBody = this.transform.GetChild(0).gameObject.AddComponent<Rigidbody>();
                    gameObjectsRigidBody.mass = 5;
                    gameObjectsRigidBody.collisionDetectionMode = CollisionDetectionMode.Continuous;
                    gameObjectsRigidBody.useGravity = false;
                }

                // Check if the object has a BoxCollider component
                BoxCollider boxCollider = this.transform.GetChild(0).gameObject.GetComponent<BoxCollider>();

                // If the BoxCollider component doesn't exist, add it
                if (boxCollider == null)
                {
                    boxCollider = this.transform.GetChild(0).gameObject.AddComponent<BoxCollider>();
                    boxCollider.providesContacts = true;
                    //boxCollider.isTrigger = true;
                }

                //see if there is collision detection script
                CollisionDetect collisionDetect = this.transform.GetChild(0).gameObject.GetComponent<CollisionDetect>();

                //if not, then add the script component
                if (collisionDetect == null)
                {
                    if(ScriptLoadCount < 1)
                    {
                        ScriptLoadCount++;
                        collisionDetect = this.transform.GetChild(0).gameObject.AddComponent<CollisionDetect>();
                    }
                    
                }
                


            }

        }
        //this is the script for the Goat
        else if (gameObject.name == "Goat.glb")
        {
            //set the tag
            gameObject.tag = "Enemy";

            ///// Check if the object has a BoxCollider component
            //BoxCollider boxCollider1 = this.gameObject.GetComponent<BoxCollider>();

            //// If the BoxCollider component doesn't exist, add it
            //if (boxCollider1 == null)
            //{
            //    boxCollider1 = this.gameObject.AddComponent<BoxCollider>();
            //    boxCollider1.providesContacts = true;
            //}

            ////check if the object has a rigid body component
            //Rigidbody gameObjectsRigidBody1 = this.gameObject.GetComponent<Rigidbody>();

            //// If the BoxCollider component doesn't exist, add it
            //if (gameObjectsRigidBody1 == null)
            //{
            //    gameObjectsRigidBody1 = this.gameObject.AddComponent<Rigidbody>();
            //    gameObjectsRigidBody1.mass = 5;
            //    gameObjectsRigidBody1.collisionDetectionMode = CollisionDetectionMode.Continuous;
            //}

            if (transform.childCount > 0)
            {
                //set the tag
                gameObject.transform.GetChild(0).tag = "Enemy";

                // Check if the object has a BoxCollider component
                BoxCollider boxCollider = this.transform.GetChild(0).gameObject.GetComponent<BoxCollider>();

                // If the BoxCollider component doesn't exist, add it
                if (boxCollider == null)
                {
                    boxCollider = this.transform.GetChild(0).gameObject.AddComponent<BoxCollider>();
                    boxCollider.isTrigger = true;
                    //boxCollider.providesContacts = true;
                }

                ////check if the object has a rigid body component
                //Rigidbody gameObjectsRigidBody = this.transform.GetChild(0).gameObject.GetComponent<Rigidbody>();

                //// If the BoxCollider component doesn't exist, add it
                //if (gameObjectsRigidBody == null)
                //{
                //    gameObjectsRigidBody = this.transform.GetChild(0).gameObject.AddComponent<Rigidbody>();
                //    gameObjectsRigidBody.mass = 20;
                //    gameObjectsRigidBody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
                //}

                //check if the z value of the object is 400 (right end of the plane)
                if (this.transform.GetChild(0).transform.position.z >= 400f)
                {
                    //raise the flag
                    GoatKeepGoing = false;

                    //rotate the object
                    this.transform.GetChild(0).transform.rotation = Quaternion.Euler(0f, 180f, 0f);

                }
                else if (this.transform.transform.GetChild(0).position.z <= -400f)
                {
                    //raise a flag
                    GoatKeepGoing = true;

                    //back to normal
                    this.transform.GetChild(0).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                }

                //check the flag 
                if (GoatKeepGoing)
                {
                    //move the object to the right
                    this.transform.transform.GetChild(0).position += new Vector3(0f, 0f, 50f) * Time.deltaTime;
                }
                else
                {
                    this.transform.transform.GetChild(0).position += new Vector3(0f, 0f, -50f) * Time.deltaTime;
                }
            }

        }
        //this is the script for Bison
        else if (gameObject.name == "Bison.glb")
        {
            //set the tag
            gameObject.tag = "Enemy";

            if (transform.childCount > 0)
            {
                //set the tag
                gameObject.transform.GetChild(0).tag = "Enemy";

                // Check if the object has a BoxCollider component
                BoxCollider boxCollider = this.transform.GetChild(0).gameObject.GetComponent<BoxCollider>();

                // If the BoxCollider component doesn't exist, add it
                if (boxCollider == null)
                {
                    boxCollider = this.transform.GetChild(0).gameObject.AddComponent<BoxCollider>();
                    //boxCollider.providesContacts = true;
                    boxCollider.isTrigger = true;
                }

                ////check if the object has a rigid body component
                //Rigidbody gameObjectsRigidBody = this.transform.GetChild(0).gameObject.GetComponent<Rigidbody>();

                //// If the BoxCollider component doesn't exist, add it
                //if (gameObjectsRigidBody == null)
                //{
                //    gameObjectsRigidBody = this.transform.GetChild(0).gameObject.AddComponent<Rigidbody>();
                //    gameObjectsRigidBody.mass = 50;
                //    gameObjectsRigidBody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
                //}

                //check if the z value of the object is 400 (right end of the plane)
                if (this.transform.GetChild(0).transform.position.z >= 400f)
                {
                    //raise the flag
                    BisonKeepGoing = false;

                    //rotate the object
                    this.transform.GetChild(0).transform.rotation = Quaternion.Euler(0f, 180f, 0f);

                }
                else if (this.transform.transform.GetChild(0).position.z <= -400f)
                {
                    //raise a flag
                    BisonKeepGoing = true;

                    //back to normal
                    this.transform.GetChild(0).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                }

                //check the flag 
                if (BisonKeepGoing)
                {
                    //move the object to the right
                    this.transform.transform.GetChild(0).position += new Vector3(0f, 0f, 700f) * Time.deltaTime;
                }
                else
                {
                    this.transform.transform.GetChild(0).position += new Vector3(0f, 0f, -700f) * Time.deltaTime;
                }
            }
        }
        //this is the script for ferret
        else if (gameObject.name == "Ferret.glb")
        {
            //set the tag
            gameObject.tag = "Enemy";

            if (transform.childCount > 0)
            {
                //set the tag
                gameObject.transform.GetChild(0).tag = "Enemy";

                // Check if the object has a BoxCollider component
                BoxCollider boxCollider = this.transform.GetChild(0).gameObject.GetComponent<BoxCollider>();

                // If the BoxCollider component doesn't exist, add it
                if (boxCollider == null)
                {
                    boxCollider = this.transform.GetChild(0).gameObject.AddComponent<BoxCollider>();
                    //boxCollider.providesContacts = true;
                    boxCollider.isTrigger = true;

                }

                ////check if the object has a rigid body component
                //Rigidbody gameObjectsRigidBody = this.transform.GetChild(0).gameObject.GetComponent<Rigidbody>();

                //// If the BoxCollider component doesn't exist, add it
                //if (gameObjectsRigidBody == null)
                //{
                //    gameObjectsRigidBody = this.transform.GetChild(0).gameObject.AddComponent<Rigidbody>();
                //    gameObjectsRigidBody.mass = 10;
                //    gameObjectsRigidBody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
                //}

                //check if the z value of the object is 400 (right end of the plane)
                if (this.transform.GetChild(0).transform.position.z >= 400f)
                {
                    //raise the flag
                    FerretKeepGoing = false;

                    //rotate the object
                    this.transform.GetChild(0).transform.rotation = Quaternion.Euler(0f, 180f, 0f);

                }
                else if (this.transform.transform.GetChild(0).position.z <= -400f)
                {
                    //raise a flag
                    FerretKeepGoing = true;

                    //back to normal
                    this.transform.GetChild(0).transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                }

                //check the flag 
                if (FerretKeepGoing)
                {
                    //move the object to the right
                    this.transform.transform.GetChild(0).position += new Vector3(0f, 0f, 800f) * Time.deltaTime;
                }
                else
                {
                    this.transform.transform.GetChild(0).position += new Vector3(0f, 0f, -800f) * Time.deltaTime;
                }
            }
        }
        else if (gameObject.name == "Soccer Goal.glb")
        {
            //set the tag
            gameObject.tag = "Goal";

            if (transform.childCount > 0)
            {
                //set the tag
                gameObject.transform.GetChild(0).tag = "Goal";

                // Check if the object has a BoxCollider component
                BoxCollider boxCollider = this.transform.GetChild(0).gameObject.GetComponent<BoxCollider>();

                // If the BoxCollider component doesn't exist, add it
                if (boxCollider == null)
                {
                    boxCollider = this.transform.GetChild(0).gameObject.AddComponent<BoxCollider>();
                    boxCollider.isTrigger = true;
                    //boxCollider.providesContacts = true;
                }

                ////check if the object has a rigid body component
                //Rigidbody gameObjectsRigidBody = this.transform.GetChild(0).gameObject.GetComponent<Rigidbody>();

                //// If the BoxCollider component doesn't exist, add it
                //if (gameObjectsRigidBody == null)
                //{
                //    gameObjectsRigidBody = this.transform.GetChild(0).gameObject.AddComponent<Rigidbody>();
                //    gameObjectsRigidBody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
                //}
            }

        }
        //any other objects
        else
        {
            if (transform.childCount > 0)
            {

                // Check if the object has a BoxCollider component
                BoxCollider boxCollider = this.transform.GetChild(0).gameObject.GetComponent<BoxCollider>();

                // If the BoxCollider component doesn't exist, add it
                if (boxCollider == null)
                {
                    boxCollider = this.transform.GetChild(0).gameObject.AddComponent<BoxCollider>();
                    //boxCollider.providesContacts = true;
                    boxCollider.isTrigger = true;

                }

                ////check if the object has a rigid body component
                //Rigidbody gameObjectsRigidBody = this.transform.GetChild(0).gameObject.GetComponent<Rigidbody>();

                //// If the BoxCollider component doesn't exist, add it
                //if (gameObjectsRigidBody == null)
                //{
                //    gameObjectsRigidBody = this.transform.GetChild(0).gameObject.AddComponent<Rigidbody>();
                //    gameObjectsRigidBody.mass = 1000;
                //    gameObjectsRigidBody.collisionDetectionMode = CollisionDetectionMode.Continuous;
                //}
            }
        }
    }

    //void onTriggerEnter(Collider other)
    //{
    //    Debug.Log("Collision!!!! by trigger Enter");

    //    //if (other.gameObject.tag == "Enemy")
    //    //{
    //    //    Debug.Log("Collision!!!!");
    //    //    //Destroy(this);
    //    //}

    //}

    //void onCollisionEnter(Collision other)
    //{
    //    Debug.Log("Collision!!!! by collision Enter");

    //    //if (other.gameObject.tag == "Enemy")
    //    //{
    //    //    Debug.Log("Collision!!!!");
    //    //    //Destroy(this);
    //    //}

    //}
}