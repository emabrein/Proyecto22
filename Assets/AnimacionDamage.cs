using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimacionDamage : MonoBehaviour
{

    Animator anim;
    bool Damage = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Trampa") == true || collision.gameObject.CompareTag("Acido"))
        {
            Damage = true;
            anim.SetTrigger("tomoDanio");
        }
    }
}
