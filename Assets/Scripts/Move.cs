using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
   
    public float velocidad=4.0f;
    public float salto=1.0f;

    Rigidbody2D rb2d;

    private bool saltando=false;
    // Start is called before the first frame update

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
       
        
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime,0, 0);
        if(Input.GetKeyUp(KeyCode.Space)&& !saltando){
   
            rb2d.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
            }
            
    }
    private void OnCollisionEnter2D(Collision2D enemigo){
        if (enemigo.collider.CompareTag("Piso")){
        saltando=false;
    }
    }
        private void OnCollisionExit2D(Collision2D enemigo){ 
        if(enemigo.collider.CompareTag("Enemy")){
        Debug.Log("sale");
    }
    if (enemigo.collider.CompareTag("Piso")){
        saltando=true;
    }
    }
}   
