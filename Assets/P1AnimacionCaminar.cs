using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1AnimacionCaminar : MonoBehaviour
{
    Animator anim;
    bool Caminar = false;

    // Start is called before the first frame update
    void Start()
    {
      anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      if ((Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.D))))
      {
        Caminar = true;
        anim.SetBool("Caminar", true);
      
      }

      else if ((Input.GetKeyUp(KeyCode.A) || (Input.GetKeyUp(KeyCode.D) || (Input.GetKeyUp(KeyCode.LeftArrow) || (Input.GetKeyUp(KeyCode.RightArrow))))))
      {
        Caminar = false;
        anim.SetBool("Caminar", false);
      }
       
    }
 }
