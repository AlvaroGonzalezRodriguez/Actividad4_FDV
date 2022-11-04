using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public float speed = 5.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
   
        Vector3 posicion = new Vector3 (h, 0.0f, v);

        if (posicion != Vector3.zero) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(posicion.normalized), 0.15f);
        transform.Translate(posicion * speed * Time.deltaTime, Space.World);
        
    }

    public void Turbo()
    {
        if(speed < 10)
        {
            speed = speed * 3;
        }
    }

    public void Normal()
    {
        if(speed >= 10)
        {
            speed = speed / 3;
        }
    }
}
