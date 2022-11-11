using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void Players()
    {
         SceneManager.LoadScene("Players");
    }

    public void Play1()
    {
        SceneManager.LoadScene("Level.1");
        Time.timeScale = 1f;
    }

    public void Play2()
    {
        SceneManager.LoadScene("Level.1v2");
        Time.timeScale = 1f;
    }

    public void Menu()
    {
        SceneManager.LoadScene("INICIO1");
    }
    
}