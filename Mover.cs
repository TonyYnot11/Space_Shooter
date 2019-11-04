using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    void Start()
    {
        var rb = GetComponent<Rigidbody>();

        rb.velocity = transform.forward * speed;


    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
