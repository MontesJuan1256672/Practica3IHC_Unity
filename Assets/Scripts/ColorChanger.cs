using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : Interactable
{
    //public Color[] colors;
    private Material material;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    protected override void Interac()
    {
        base.Interac();
        
        //cambio de color
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        material.color = new Color(r, g, b, 1f);

    }
}
