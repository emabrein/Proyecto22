using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using UnityEngine.UI;

public class MuerteV2 : MonoBehaviour
{
    public Sprite[] corazones;
    public int vida = 3;

    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trampa"))
        {
            if (vida > 0)
            {
                vida--;
                this.GetComponent<Image>().sprite = corazones[pos];
            }
            else if (vida <= 0)
            {
                Thread.Sleep(100);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}