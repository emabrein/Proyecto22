using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSonido : MonoBehaviour
{
    public static ControladorSonido Instance;
    private AudioSource SoundQueso;

    private void Awake()
    {
        if (Instance = null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }

        SoundQueso = GetComponent<AudioSource>();
    }

    public void EjecutarSonido(AudioClip sonido)
    {
        SoundQueso.PlayOneShot(sonido);
    }
}
