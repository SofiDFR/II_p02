using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDistances : MonoBehaviour
{
    private GameObject cubo;
    private GameObject cilindro;
    private Transform transformCubo, transformCilindro, transformEsfera;
    // Start is called before the first frame update
    void Start()
    {
        cubo = GameObject.FindWithTag("red_cube");
        cilindro = GameObject.FindWithTag("green_cylinder");

        transformCubo = cubo.GetComponent<Transform>();
        transformCilindro = cilindro.GetComponent<Transform>();
        transformEsfera = transform;

        float distanciaCubo = Vector3.Distance(transformEsfera.position, transformCubo.position);
        float distanciaCilindro = Vector3.Distance(transformEsfera.position, transformCilindro.position);

        Debug.Log("Distancia Esfera-Cubo: " + distanciaCubo);
        Debug.Log("Distancia Esfera-Cilindro: " + distanciaCilindro);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
