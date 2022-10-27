using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionSaltar : MonoBehaviour
{
    Animator anim;
    bool Saltar = false;
    float velY;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)))
        //{
        //  Saltar = true;
        //  Caminar = false
        //  anim.SetBool("Saltar", true);
        //}

        //else if ((Input.GetKeyUp(KeyCode.Space) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.W)))
        //{
        //  Saltar = false;
        //  anim.SetBool("Saltar", false);
        //}
        anim.SetFloat("Y vel", GetComponent<Rigidbody2D>().velocity.y);
    }
}