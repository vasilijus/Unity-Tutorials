﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We turn the Propeller
        // transform.Rotate(Vector3.up);
        transform.Rotate(0, 0, 5);
    }
}
