using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    private Vector3 posicionOriginal;
    private Marcador marcador;
    public int indice;
    private Vector3 desplazamiento;
    private bool saltoPresionado = false;

    // Start is called before the first frame update
    void Start()
    {
        marcador = GameObject.Find("Marcador").GetComponent<Marcador>();

        if (indice >= 0 && indice < marcador.desplazamientos.Length)
        {
            desplazamiento = marcador.desplazamientos[indice];
        }
        else
        {
            Debug.LogWarning("Índice fuera de rango para el desplazamiento del objeto: " + gameObject.name);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float entradaSalto = Input.GetAxis("Jump");
        
        if (entradaSalto > 0 && !saltoPresionado)
        {
            Vector3 nuevaPosicion = transform.position + desplazamiento;
            transform.position = nuevaPosicion;
            saltoPresionado = true;    
        }
        else if (entradaSalto == 0)
        {
            saltoPresionado = false;
        }
    }
}
