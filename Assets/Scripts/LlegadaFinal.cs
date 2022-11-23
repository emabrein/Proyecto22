using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LlegadaFinal : MonoBehaviour
{
    private AudioSource SonidoLlegada;
    private AudioSource MusicaFinal;
    private AudioSource Wii;
    
    [SerializeField] GameObject WinMenu;
     
    private void Start()
    {
        SonidoLlegada = GetComponent<AudioSource>();
        MusicaFinal = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Wii.Pause();
            SonidoLlegada.Play();
            Invoke("CompleteLevel", 2f);
            MusicaFinal.Play();
        }
    }

    private void CompleteLevel()
    {
        
        WinMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    
     
    

    public void QuitGame()
    {
         Application.Quit();
    }
    public void BackToMenu()
  {
       SceneManager.LoadScene("INICIO1");
  }
  public void Retry()
  {
      SceneManager.LoadScene("Level.1");
      Time.timeScale = 1f;
  }

  public void Retry2()
  {
      SceneManager.LoadScene("Level.1v2");
      Time.timeScale = 1f;
  }
}
