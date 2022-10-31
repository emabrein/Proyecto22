using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaOnTrigger : MonoBehaviour
{
    [SerializeField] GameObject PuertaS;

    void OnTriggerEnter2D(Collider2D collision)
    {
        PuertaS.transform.position += new Vector3 (0, -2.36f, 0);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        PuertaS.transform.position += new Vector3 (0, 2.36f, 0);
    }
}
