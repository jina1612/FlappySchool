using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mpve : MonoBehaviour
{
    public float Speed;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }
}
