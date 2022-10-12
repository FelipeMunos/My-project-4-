using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ValidarDatos : MonoBehaviour
{
    public Text CajaNombre, CajaEdad;
    string Nombre {get;set;}
    byte Edad {get;set;}


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Validar(){
        Nombre = CajaNombre.text;
        try{
            Edad = byte.Parse(CajaEdad.text);//strin bytre
            //byte.TryParse(CajaEdad.text, out Edad);

        }
        catch(Exception ex){
            Debug.Log("Error edad no valida");
        }
        
        SceneManager.LoadScene("Nivel0");
        Debug.Log("El valor es" + Edad);
        //Debug.Log($"El valor es {edad}");

        //investigar mechcollider
        //usar time palet

    }
}
