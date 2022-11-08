using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LlegadaFinal : MonoBehaviour
{
    private AudioSource SonidoLlegada;
    
    [SerializeField] GameObject WinMenu;
     
    private void Start()
    {
        SonidoLlegada = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SonidoLlegada.Play();
            Invoke("CompleteLevel", 2f);
        }
    }

    
    
        //     void LlegadaFinal.OnTriggerEnter2D (Collider2D collision)
        // {
        // if (collision.gameObject.name == "Player")
        // {
        //     WinMenu.SetActive(true);
        // }
        // }
    

    public void QuitGame()
    {
         Application.Quit();
    }
    public void BackToMenu()
  {
    //   Application.LoadLevel("INICIO1");
  }
  public void Retry()
  {
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      Time.timeScale = 1f;
  }
}
