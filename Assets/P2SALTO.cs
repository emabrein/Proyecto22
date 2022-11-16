using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2SALTO : MonoBehaviour
{ 
  
    float velY;
    public float Salto = 4.5f;
    bool enGround = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (enGround)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, Salto);
                enGround = false;
                
            }

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        {
            if (collision.transform.tag == "ground")
            {
                enGround = true;
            }

            else if (collision.transform.tag == "Trampa")
            {
                enGround = true;
            }

            else if (collision.transform.tag == "Player1")
            {
                enGround = true;
            }
        }
    }
}
