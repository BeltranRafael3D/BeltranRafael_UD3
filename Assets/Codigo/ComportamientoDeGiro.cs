﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamientoDeGiro : MonoBehaviour
{
    public float velocidadgirocubo;
    Vector3 velocidadRotacion = new Vector3(15, 30, 45);

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(velocidadRotacion*velocidadgirocubo*Time.deltaTime);
    }
}