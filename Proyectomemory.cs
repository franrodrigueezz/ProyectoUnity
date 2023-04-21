using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Proyectomemory : MonoBehaviour
{
    public Sprite[] myImages;
    public GameObject Manager;

    void Start()
    {

    }

    void GetCardFaces()
    {

    }

    public void Elegircarta(Image imagen)
    {
       
      imagen.sprite = Manager.GetComponent<Proyectomemory>().myImages[Random.Range(0, 10)];
    }
}