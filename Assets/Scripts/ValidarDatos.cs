using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class ValidarDatos : MonoBehaviour
{
    public Text CajaNombre, CajaEdad;
    string Nombre {get;set;}
     /* get solo lectura. set solo escritura | Siempre va estas dos cuando la variable esta en mayuscula */
    byte Edad {get;set;}/* si esta con mayuscula es un gether y sether, minuscula un campo /
    Start is called before the first frame update*/
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Validar(){
        Nombre = CajaNombre.text; /* text va co minuscula por que es un campo que recibe */
        try{
            Edad = byte.Parse(CajaEdad.text);
            //byte.TryParse(CajaEdad.text, out Edad); este nos ahorra el try

        }
        catch(Exception ex){
            Debug.Log("Error edad no valida");
        }
        SceneManager.LoadScene("Nivel0");
        Debug.Log("El valor es" + Edad);
        //Debug.Log($"El valor es {Edad}"); otra concatenacion investigar Matchcollider
    }
}