﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockmovement : MonoBehaviour
{
    public float speed = 1.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

         
        
         
        
    }
}
