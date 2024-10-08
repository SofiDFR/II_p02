using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageSpheres : MonoBehaviour
{
    public GameObject cubo;
    private GameObject[] esferasTipo2;
    private Vector3 posicionCuboAnterior;

    // Start is called before the first frame update
    void Start()
    {
        esferasTipo2 = GameObject.FindGameObjectsWithTag("type2_sphere");
        posicionCuboAnterior = cubo.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (esferasTipo2.Length == 0) return;

        if (cubo.transform.position != posicionCuboAnterior)
        {
            GameObject esferaMasCercana = ObtenerEsferaMasCercana(cubo.transform.position);
            if (esferaMasCercana != null)
            {
                Vector3 nuevaPos = esferaMasCercana.transform.position;
                nuevaPos.y += 0.1f;
                esferaMasCercana.transform.position = nuevaPos;
            }
            posicionCuboAnterior = cubo.transform.position;
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject esferaMasLejana = ObtenerEsferaMasLejana(cubo.transform.position);
            if  (esferaMasLejana != null)
            {
                Renderer renderer = esferaMasLejana.GetComponent<Renderer>();
                renderer.material.color = new Color(Random.value, Random.value, Random.value);
            }
        }
    }

    GameObject ObtenerEsferaMasCercana(Vector3 posicionCubo)
    {
        GameObject esferaMasCercana = null;
        float minDistancia = Mathf.Infinity;

        foreach (GameObject esfera in esferasTipo2)
        {
            float distancia = Vector3.Distance(posicionCubo, esfera.transform.position);
            if (distancia < minDistancia)
            {
                minDistancia = distancia;
                esferaMasCercana = esfera;
            }
        }
        return esferaMasCercana;
    }

    GameObject ObtenerEsferaMasLejana(Vector3 posicionCubo)
    {
        GameObject esferaMasLejana = null;
        float maxDistancia = 0f;

        foreach (GameObject esfera in esferasTipo2)
        {
            float distancia = Vector3.Distance(posicionCubo, esfera.transform.position);
            if (distancia > maxDistancia)
            {
                maxDistancia = distancia;
                esferaMasLejana = esfera;
            }
        }
        return esferaMasLejana;
    }
}
