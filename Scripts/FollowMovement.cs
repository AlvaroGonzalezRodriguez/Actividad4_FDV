using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMovement : MonoBehaviour
{
    public Transform goal;
    public float speed = 0.1f;
    public float accuracy = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(goal.position);
        Vector3 direction = new Vector3(goal.position.x - transform.position.x, 0.0f, goal.position.z - transform.position.z);
        if(direction.magnitude > accuracy) {
            transform.Translate(direction.normalized * speed * Time.deltaTime, Space.World);
        }
        Debug.DrawRay(transform.position,direction,Color.red);
    }
}
