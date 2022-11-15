using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movimiento : MonoBehaviour
{
    public Text textoVida;
    public float velocidad=6.0f;
    public short vida=10000;//enteros 16
    public float salto=10.0f;
    Rigidbody2D rb2d;
    private bool saltando=false;
    // Start is called before the first frame update
    void Start()
    {
        textoVida.text = vida.ToString();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime,0, 0);
        if(Input.GetKey(KeyCode.Space) && !saltando){
   
            rb2d.AddForce(Vector2.up * salto);
           
        }
        //Debug.Log(saltando);
    }
    private void OnCollisionEnter2D(Collision2D obj){
        if(obj.collider.CompareTag("Enemigo")){
            Debug.Log("Entre, enemigo encontrado");//console.log() //javascript
            Destroy(obj.collider.gameObject);
        }
        if(obj.collider.CompareTag("Piso")){
            saltando = false;
        }
        
    }
    private void OnCollisionExit2D(Collision2D obj){
        if(obj.collider.CompareTag("Enemigo")){
            Debug.Log("Sali");
        }
        if(obj.collider.CompareTag("Piso")){
            saltando = true;
        }
        
    }
    private void OnCollisionStay2D(Collision2D obj){
        if(obj.collider.CompareTag("Enemigo")){
            Debug.Log("Mantengo");
        }
        
    }

    private void OnTriggerEnter2D(Collider2D obj){
        if(obj.CompareTag("PowerUp")){
            Debug.Log("Pow");
            salto= 20f;
        }
    }
    private void OnTriggerExit2D(Collider2D obj){
        if(obj.CompareTag("PowerUp")){
            Debug.Log("Pow");
            salto= 10f;
            Destroy(obj.gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D obj){
        if(obj.CompareTag("EnemigoOP")){
            //restar vida
            vida--;//vida= vida-1;
            textoVida.text = vida.ToString();
        }
    }
}




