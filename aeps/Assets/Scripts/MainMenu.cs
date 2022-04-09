using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    ////private void Start()
    ////{
    ////    Debug.Log("Hello");
    ////}

    public void LoadLevelSelectMenu() //Changes to Level Select Menu
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame() //Quits Game
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //Application.Quit();       
    }
}
