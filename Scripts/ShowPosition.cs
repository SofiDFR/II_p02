using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPosition : MonoBehaviour
{
    private Vector3 posicion;
    private GUIStyle estiloTexto;

    void Start()
    {
        estiloTexto = new GUIStyle();
        estiloTexto.normal.textColor = Color.black;
        estiloTexto.fontSize = 50;
    }
    // Update is called once per frame
    void Update()
    {
        posicion = transform.position;
    }

    void OnGUI()
    {
        GUI.Label(new Rect(20, 20, 300, 40), "Posición de la Esfera: " + posicion, estiloTexto);
    }
}
