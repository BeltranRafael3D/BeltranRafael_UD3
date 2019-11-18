using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDelJugador : MonoBehaviour
{

    Rigidbody rb;
    public float velocidad;
    int contador;

    public Text marcador;
    public Text finJuego;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        ActualizarMarcador();
        finJuego.gameObject.SetActive(false);
    }

    public void FixedUpdate()
    {

       float movimientoHorizontal = Input.GetAxis("Horizontal");
       float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoVertical);
        rb.AddForce(movimiento);
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        contador = contador + 1;
        ActualizarMarcador();
        if (contador >= 4)
        {
            finJuego.gameObject.SetActive(true);
        }


    }

    public void ActualizarMarcador()
    {
        marcador.text = "Puntos: " + contador;
    }

    
}
