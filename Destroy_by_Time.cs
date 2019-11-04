using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_by_Time : MonoBehaviour
{
    public float LifeTime;
    private void Start()
    {
        Destroy(gameObject, LifeTime);
    }
}
