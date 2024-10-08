using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    private Renderer objRenderer;

    // Start is called before the first frame update
    void Start()
    {
        objRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("green_cylinder") && Input.GetKeyDown(KeyCode.C))
        {
            objRenderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
        if (gameObject.CompareTag("red_cube") && Input.GetKeyDown(KeyCode.UpArrow))
        {
            objRenderer.material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
