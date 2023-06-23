using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CollisionDetect : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else if(other.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

    }

}
