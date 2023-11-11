using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNull : MonoBehaviour
{
    string firstname = "Dipo";
    string lastname = null;
    int? meaningoflife = null;
    // Start is called before the first frame update
    void Start()
    {
        int? anotherlife = null;
        int trueenumber = meaningoflife ?? anotherlife ?? 42;
        Debug.Log(trueenumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
