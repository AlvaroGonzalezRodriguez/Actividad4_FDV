using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suscriptor : MonoBehaviour
{
    public Notificador notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.launch += Respond;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Respond() 
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0,2000,2000));
    }
}
