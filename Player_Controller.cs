using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Boundary
    {
        public float xMin, xMax, zMin, zMax;
    }


public class Player_Controller : MonoBehaviour
{
    
    public float speed;
    public float tilt;
    public Boundary boundary;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;


    private void Update()
    {
        /*Input.GetButton()
        Instantiate(shot, shotSpawn.position, shotSpawn.rotation);   Input.GetButton("Fire1") Input.GetKeyDown( KeyCode.Space )*/
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);// as GameObject;
            GetComponent<AudioSource>().Play();
        }

    }

    private void FixedUpdate()
    {
        
        var rb = GetComponent<Rigidbody>();
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().velocity = movement * speed;
        GetComponent<Rigidbody>().position = 
            new Vector3
            (
                Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
                0.0f,
                Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
            );

        rb.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.x * -tilt);
    }
}
