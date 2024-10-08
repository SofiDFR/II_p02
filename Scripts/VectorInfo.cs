using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorInfo : MonoBehaviour
{
    public Vector3 vector_1, vector_2;

    public float magnitud_1, magnitud_2;
    public float angulo;
    public float distancia;
    public string vector_mayor_altura;

    // Start is called before the first frame update
    void Start()
    {
        magnitud_1 = vector_1.magnitude;
        magnitud_2 = vector_2.magnitude;

        angulo = Vector3.Angle(vector_1, vector_2);
        distancia = Vector3.Distance(vector_1, vector_2);

        if (vector_1.y > vector_2.y)
        {
            vector_mayor_altura = "Vector 1 está a mayor altura";
        }
        else if (vector_1.y < vector_2.y)
        {
            vector_mayor_altura = "Vector 1 está a mayor altura";
        }
        else
        {
            vector_mayor_altura = "Ambos vectores están a la misma altura";
        }

        Debug.Log("Magnitud del vector 1: " + magnitud_1);
        Debug.Log("Magnitud del vector 2: " + magnitud_2);
        Debug.Log("Ángulo entre los vectores: " + angulo + " grados");
        Debug.Log("Distancia entre los vectores: " + distancia);
        Debug.Log(vector_mayor_altura);
    }

    // Update is called once per frame
    void Update()
    {
        magnitud_1 = vector_1.magnitude;
        magnitud_2 = vector_2.magnitude;

        angulo = Vector3.Angle(vector_1, vector_2);
        distancia = Vector3.Distance(vector_1, vector_2);

        if (vector_1.y > vector_2.y)
        {
            vector_mayor_altura = "Vector 1 está a mayor altura";
        }
        else if (vector_1.y < vector_2.y)
        {
            vector_mayor_altura = "Vector 1 está a mayor altura";
        }
        else
        {
            vector_mayor_altura = "Ambos vectores están a la misma altura";
        }
    }
}
