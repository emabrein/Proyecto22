using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2MOVIMIENTO : MonoBehaviour
{

    GameObject Player1;

    Rigidbody2D RB2D;
    SpriteRenderer SR;
    Vector3 direction;
    float MovementSpeed = 1;
    public float movVel;
    float velX;
    float velY;
    bool vista = true;
    Rigidbody2D rigCuerpo;

  

    // Start is called before the first frame update
    void Start()
    {
         RB2D = GetComponent<Rigidbody2D>();
         SR = GetComponent<SpriteRenderer>();
         direction = new Vector3 (0,0,0);

         rigCuerpo = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    
    void Update()
    {

        transform.position += direction * Time.deltaTime * MovementSpeed;

        velY = rigCuerpo.velocity.y;
        velX = Input.GetAxisRaw("HorizontalP2");
        rigCuerpo.velocity = new Vector2 (velX * movVel, velY);
        
    }

    void LateUpdate()
    {
        Vector3 localScale = transform.localScale;
        if (velX > 0)
        {
            vista = true;
        }

        else if (velX < 0)
        {
            vista = false;
        }

        if (((vista) && (localScale.x < 0)) || ((!vista) && (localScale.x > 0)))
        {
            localScale.x *= -1;
        }

        transform.localScale = localScale;
    }

}

