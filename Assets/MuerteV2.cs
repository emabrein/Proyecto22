using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MuerteV2 : MonoBehaviour
{
    public int vida;
    public Lives lifeUI;
    public bool invincible;

    [SerializeField] GameObject OverMenu;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            GetHit(4);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trampa"))
            GetHit(1);

        else if(collision.gameObject.CompareTag("Acido"))
        {
            GetHit(4);
        }
    }
    public void GetHit(int dmg)
    {
        if (invincible)
        {
            Debug.Log("invincible");
            return;
        }
        Debug.Log("hurt");
        if (vida > 0)
        {
            vida-= dmg;
            lifeUI.CambioVida(vida);
        }
        else if (vida <= 0)
        {
        OverMenu.SetActive(true);
        Time.timeScale = 0f;
        }
    }

}