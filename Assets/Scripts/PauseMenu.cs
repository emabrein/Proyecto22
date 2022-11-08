using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour 
{

  public static bool GameIsPaused = false;
  public GameObject PauseMenuUI;
  
  
  void Update () 
  {
    if (Input.GetKeyDown(KeyCode.Escape) && GameIsPaused == false)
    {
        Pause();
    }
    
    else if (Input.GetKeyDown(KeyCode.Escape) && GameIsPaused)
      {
          Resume();
      }
  }

   
  void Resume()
  {
    PauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
    GameIsPaused = false;
  }

  void Pause()
  {
    PauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
    GameIsPaused = true;
  }

}