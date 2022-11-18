using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoQueso : MonoBehaviour
{
    AudioSource SoundQueso;

    void Start()
    {
        SoundQueso = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Collectible") == true)
        {

            SoundQueso.Play();

        }
    }
}
