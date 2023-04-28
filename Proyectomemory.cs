using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Proyectomemory : MonoBehaviour
{
    public Sprite[] myImages;
    public GameObject Manager;
    public int contador;
    public List<GameObject> Cartaseleccionada;
    public GameObject panelInicio;
    public GameObject panelJuego;
    public GameObject panelVictoria;
    public string nombreJugador1;
    public string nombreJugador2;
    public InputField inputNombreJugador1;
    public InputField inputNombreJugador2;
    public Text textoNombreJugador1;
    public Text textoNombreJugador2;
    


    void Start()
    {
        panelInicio.SetActive(true);
        panelJuego.SetActive(false);
        textoNombreJugador1.text = "Nombre Jugador 1: " + nombreJugador1;
        textoNombreJugador2.text = "Nombre Jugador 2: " + nombreJugador2;
       
    }

    void Update()
    {

    }

    public void Elegircarta(GameObject boton)
    {
        boton.GetComponent<Image>().enabled = false;
        boton.transform.GetChild(0).gameObject.SetActive(true);
        //imagen.sprite = Manager.GetComponent<Proyectomemory>().myImages[Random.Range(0, 10)];
        contador++;
        Cartaseleccionada.Add(boton);
        if (contador > 2)
        {
            if (Cartaseleccionada[0].gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name
                  == Cartaseleccionada[1].gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name)
            {
                contador = 0;
                Cartaseleccionada.Clear();
            }
            else
            {
                Cartaseleccionada[0].gameObject.transform.GetComponent<Image>().enabled = true;
                Cartaseleccionada[0].gameObject.transform.transform.GetChild(0).gameObject.SetActive(false);
                Cartaseleccionada[1].gameObject.transform.GetComponent<Image>().enabled = true;
                Cartaseleccionada[1].gameObject.transform.transform.GetChild(0).gameObject.SetActive(false);
                contador = 0;
                Cartaseleccionada.Clear();
            }
            
        }
    }
    public void IniciarPartida()
    {
        panelInicio.SetActive(false);
        panelJuego.SetActive(true);
    }

    public void ObtenerNombresJugadores()
    {
        nombreJugador1 = inputNombreJugador1.text;
        nombreJugador2 = inputNombreJugador2.text;
        panelInicio.SetActive(false);
        panelJuego.SetActive(true);
    }

    public void BotonSalir()
    {
        Application.Quit();
    }

    public void BotonVolverAlMenu()
    {
        panelJuego.SetActive(false);
        panelVictoria.SetActive(false);
        panelInicio.SetActive(true);
    }

}