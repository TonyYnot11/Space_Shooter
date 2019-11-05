using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{

    public float scroll_speed;
    public float tileSize;
    private Transform currentobject;



    
    void Start()
    {

        currentobject = GetComponent<Transform>();
        
    }    
    void Update()
    {

        currentobject.position = new Vector3(
            currentobject.position.x,
            currentobject.position.y,
            Mathf.Repeat(Time.time * scroll_speed, tileSize)
            );
        
    }
}
