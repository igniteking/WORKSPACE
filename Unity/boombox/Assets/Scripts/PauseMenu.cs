using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public string loadLevel;

    // Update is called once per frame
    public void LoadScene()
    {
        SceneManager.LoadScene(loadLevel);
    }

    public void quitMenuFunction()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
