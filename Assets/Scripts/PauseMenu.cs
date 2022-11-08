using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour 
{
  // menu de pausa del primer nivel

  [SerializeField] public GameObject botonPausa;
  [SerializeField] public GameObject pauseMenuUI;
  [SerializeField] public GameObject botonPlayLCDLL;
  
   
  public void showHistoria()
  {
    botonPausa.SetActive(true);
    pauseMenuUI.SetActive(false);
    botonPlayLCDLL.SetActive(true);
  }

  public void hideHistoria()
  {
    botonPausa.SetActive(false);
    pauseMenuUI.SetActive(true);
    botonPlayLCDLL.SetActive(false);
  }
  
  public void Continue()
  {
    botonPausa.SetActive(true);
    pauseMenuUI.SetActive(false);
    Time.timeScale = 1f;
  }

  public void Pause()
  {
    botonPausa.SetActive(false);
    pauseMenuUI.SetActive(true);
    Time.timeScale = 0f;
  }

  public void Retry()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      Time.timeScale = 1f;
  }

  public void BackToMenu()
  {
      Application.LoadLevel("INICIO1");
  }

}