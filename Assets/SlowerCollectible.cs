using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowerCollectible : MonoBehaviour
{
    private float speed;
    private float BoostTimer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Slower") == true) ;
        
         

    }
}
