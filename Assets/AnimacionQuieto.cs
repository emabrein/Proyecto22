﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionQuieto : MonoBehaviour
{
    Animator anim;
    bool Quieto = false;
    bool Caminar = false;
    bool Saltar = false;
    bool Damage = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame

    void Update()
    {
        if (Caminar == false && Saltar == false && Damage == false)
        {
            Quieto = true;
        }
            

        else
        {
            Quieto = false;
        } 
        
    }
}