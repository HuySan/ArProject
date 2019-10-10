using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public void LoadSceneMain()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadSceneMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadSceneExit()
    {
        Application.Quit();
        Debug.Log("EXIT");
    }
}
