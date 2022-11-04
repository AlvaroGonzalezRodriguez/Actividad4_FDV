using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Points : MonoBehaviour
{

    public int points = 0;
    public int strength = 100;
    public TextMeshProUGUI puntos;
    public TextMeshProUGUI fuerza;

    // Start is called before the first frame update
    void Start()
    {
        //Mostrar datos relativos a la puntuacion
        puntos.text = points.ToString();
        fuerza.text = strength.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        Renderer renderizado = collider.gameObject.GetComponent<Renderer>();
        if(renderizado.material.color == GameObject.Find("Coin").GetComponent<Renderer>().material.color)
        {
            Debug.Log("Se entro al good");
            points = points + strength;
            //Mostrar datos relativos a la puntuacion
            puntos.text = points.ToString();

        } else if (renderizado.material == GameObject.Find("CoinBad").GetComponent<Renderer>().material) 
        {
            Debug.Log("Se entro al bad");
            strength = strength - 25;
            //Mostrar datos relativos a la fuerza
            fuerza.text = strength.ToString();
        }
    }
}
