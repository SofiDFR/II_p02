using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Color color;
    public int frameDelay = 120;
    private int frameCounter;

    // Start is called before the first frame update
    void Start()
    {
        ChangeRandomColor();
        ApplyColor();
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter++;
        if (frameCounter >= frameDelay)
        {
            frameCounter = 0;
            ChangeRandomColor();
            ApplyColor();
        }
    }

    void ChangeRandomColor()
    {
        color = new Color(Random.value, Random.value, Random.value, Random.value);
    }

    void ApplyColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = color;
        }
    }
}
