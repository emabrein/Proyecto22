using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuertaOnTrigger : MonoBehaviour
{
    [SerializeField] GameObject Puerta1;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Puerta1.transform.position += new Vector3(0, -2.36f, 0);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Puerta1.transform.position += new Vector3(0, 2.36f, 0);
    }
}