using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta2OnTrigger : MonoBehaviour
{
    [SerializeField] GameObject Puerta2;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Puerta2.transform.position += new Vector3(0, -2.36f, 0);
    }

}