using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LlegadaV2 : MonoBehaviour
{
private AudioSource SonidoLlegada;
private void Start()
     {
         SonidoLlegada = GetComponent<AudioSource>();
     }
    
     private void OnTriggerEnter2D (Collider2D collision)
     {
         if (collision.gameObject.name == "Player2")
         {
             SonidoLlegada.Play();
             Invoke("CompleteLevel", 2f);
         }
     }

     private void CompleteLevel()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
     }

}
