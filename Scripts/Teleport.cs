using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform Teleport1;
    public Transform Teleport2;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "TP_1")
        {
            Vector3 vector = new Vector3(Teleport2.position.x, Teleport2.position.y, Teleport2.position.z - 2);
            transform.position = vector;

        } else if (collision.gameObject.name == "TP_2") 
        {
            Vector3 vector = new Vector3(Teleport1.position.x, Teleport1.position.y, Teleport1.position.z - 2);
            transform.position = vector;
        }
    }

    
}
