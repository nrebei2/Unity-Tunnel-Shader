using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class EditScreenShader : MonoBehaviour
{
    public Vector3 colors;
    public Vector4 noise;
    public float size;
    public float speed;
    public float intensity;
    
    private void Update()
    {
        this.GetComponent<Renderer>().sharedMaterial.SetVector("_MyColor", colors);
        this.GetComponent<Renderer>().sharedMaterial.SetVector("_Noise", noise);
        this.GetComponent<Renderer>().sharedMaterial.SetFloat("_Size", size);
        this.GetComponent<Renderer>().sharedMaterial.SetFloat("_Speed", speed);
        this.GetComponent<Renderer>().sharedMaterial.SetFloat("_Intensity", intensity);
    }
}
