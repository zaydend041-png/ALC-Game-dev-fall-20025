using System.Collections;
using System.Collecitons.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehavior
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }
}