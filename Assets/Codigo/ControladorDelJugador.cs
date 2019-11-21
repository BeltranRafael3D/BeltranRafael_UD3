using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorDelJugador : MonoBehaviour
{

    Rigidbody rb;
    public float velocidad;
    int contador;
    int numitems_1;
    int numitems_2;
    int numitems_3;

    public Text marcador;
    public Text finJuego;

    public void Awake()
    {
        rb = GetComponent<Rigidbody>();
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
     
        if (other.tag == "suma1")
            {
            Destroy(other.gameObject);
            contador = contador + 1;
            numitems_1 = numitems_1 + 1;
        }

        else if (other.tag == "suma2")
        {
            Destroy(other.gameObject);
            contador = contador + 2;
            numitems_2 = numitems_2 + 2;
        }
        else if (other.tag == "Resta1")
        {
            Destroy(other.gameObject);
            contador = contador - 1;
            numitems_3 = numitems_3 - 1;
        }

        ActualizarMarcador();

        if (numitems_1 >= 4 && numitems_2 >=2 )
        {
            finJuego.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void ActualizarMarcador()
    {
        marcador.text = "Puntos: " + contador;
    }

    
}
