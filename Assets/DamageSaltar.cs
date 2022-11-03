using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionDamageSaltar : MonoBehaviour
{

    Animator anim;
    bool DamageSaltar = false;
    bool Saltar = false;
    public int vida;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Saltar == true && vida == -1)
        {
            DamageSaltar = true;
            anim.SetBool("DamageSaltar", true);
        }

       else
        {
            DamageSaltar = false;
        }
    }
}
