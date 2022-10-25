using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionQuieto : MonoBehaviour
{
    Animator anim;
    bool Quieto = false;
    float velX;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (velX != 0)
        {
            Quieto = true;
            anim.SetBool("Quieto", true);
        }
            

        else
        {
            Quieto = false;
        } 

    }
}