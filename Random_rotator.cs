using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_rotator : MonoBehaviour
{
    public float tumble;


    private void Start()
    {
        var rb = GetComponent<Rigidbody>();

        rb.angularVelocity = Random.insideUnitSphere * tumble;

    }

}
