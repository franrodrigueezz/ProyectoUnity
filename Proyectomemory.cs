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

    void Start()
    {

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


}