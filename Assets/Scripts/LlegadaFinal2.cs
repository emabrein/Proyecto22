using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LlegadaFinal2 : MonoBehaviour
{
    private AudioSource SonidoLlegada;
    private AudioSource GTA;
    private AudioSource MusicaFinal;
    
    [SerializeField] GameObject WinMenu;
     
    private void Start()
    {
        SonidoLlegada = GetComponent<AudioSource>();
        MusicaFinal = GetComponent<AudioSource>();
        GTA = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "Player2")
        {
            SonidoLlegada.Play();
            Invoke("Complete", 2f);
            MusicaFinal.Play();
        }
    }

    private void Complete()
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
      SceneManager.LoadScene("Level.1v2");
      Time.timeScale = 1f;
  }
  public void OverGTA()
  {
      GTA.Play();
  }
}
