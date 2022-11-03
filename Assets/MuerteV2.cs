using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
using UnityEngine.UI;

public class MuerteV2 : MonoBehaviour
{
    public int vida;
    public Lives lifeUI;
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            GetHit();
            GetHit();
            GetHit();
            GetHit();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trampa"))
            GetHit();
    }
    public void GetHit()
    {
        if (vida > 0)
        {
            vida--;
            lifeUI.CambioVida(vida);
        }
        else if (vida <= 0)
        {
            Thread.Sleep(100);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}