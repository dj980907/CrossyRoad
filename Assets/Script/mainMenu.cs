using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    //method to play a game
    public void playGame()
    {
        //load the next scene by getting the active scene and getting the build index and adding one
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
