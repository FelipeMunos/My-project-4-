using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimacionPersonaje : MonoBehaviour
{
    private Animator anim;

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            anim.SetTrigger("Atacar");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.SetTrigger("Correr");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.SetTrigger("Correr");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Salto");
        }
    
    }
    
            
      
    
}