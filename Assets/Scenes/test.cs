using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int number = 5;
    string word = "1488";
    void Start()
    {
        number = Convert.ToInt32(word);
        Debug.Log(number);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
