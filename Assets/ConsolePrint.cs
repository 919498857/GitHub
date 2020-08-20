using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ConsolePrint : MonoBehaviour
{
    int i = 0;
    //GameObject BluePrefab;
    //GameObject RedPrefab;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
       
        Console.WriteLine(i++);
    }
}
