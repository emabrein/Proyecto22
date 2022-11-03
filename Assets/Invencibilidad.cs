using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invencibilidad : MonoBehaviour
{
    Renderer rend;
    Color c;
    public int vida;

    public GameObject pocion;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        c = rend.material.color;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Invencible") && vida > 0)
        {
            StartCoroutine("GetInvulnerable");
            Destroy(pocion);
        }
        
    }

    IEnumerator GetInvulnerable()
    {
        Physics2D.IgnoreLayerCollision(8, 9, true);
        c.a = 0.5f;
        rend.material.color = c;
        yield return new WaitForSeconds (3f);
       
        Physics.IgnoreLayerCollision(8, 9, false);
        c.a = 1f;
        rend.material.color = c;
    }

}
