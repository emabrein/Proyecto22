using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Sprite[] corazones;
    Image LifeUI;
    public int vidas = 3;

    // Start is called before the first frame update
    void Start()
    {
        LifeUI = GetComponent<Image>();
        CambioVida (3);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CambioVida( int pos)
    {
        LifeUI.sprite = corazones [pos];
    }

}
