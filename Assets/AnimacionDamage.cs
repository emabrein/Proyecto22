using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimacionDamage : MonoBehaviour
{

    Animator anim;
    bool Damage = false;
    AudioSource SoundDamage;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        SoundDamage = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        if((collision.gameObject.CompareTag("Trampa")) && !GetComponent<MuerteV2>().invincible)
        {
            Damage = true;
            SoundDamage.Play();
            anim.SetTrigger("tomoDanio");
        }

        else if ((collision.gameObject.CompareTag("Acido")) && !GetComponent<MuerteV2>().invincible)
        {
            Damage = true;
            SoundDamage.Play();
            anim.SetTrigger("tomoDanio");
        }
    }
}
