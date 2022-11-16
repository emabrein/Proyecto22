using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class LlegadaV1 : MonoBehaviour
{
    
    private AudioSource SonidoLlegada;
    private void Start()
    {
        SonidoLlegada = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            SonidoLlegada.Play();
            
            Invoke("CompleteLevel", 1f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



}

