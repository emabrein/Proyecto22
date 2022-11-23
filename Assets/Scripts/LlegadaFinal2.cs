﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LlegadaFinal2 : MonoBehaviour
{
    private AudioSource SonidoLlegada;
    private AudioSource Wii;
    private AudioSource MusicaFinal;
    
    [SerializeField] GameObject WinMenu;
     
    private void Start()
    {
        SonidoLlegada = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "Player2")
        {
            SonidoLlegada.Play();
            Wii.Stop();
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
}
