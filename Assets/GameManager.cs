using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int PuntosTotales {get{return puntosTotales;}}
    private int puntosTotales
    public void SumarPuntos(int puntosaSumar){
        puntosTotales = PuntosTotales + puntosaSumar
        Debug.Log(puntosTotales)
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
