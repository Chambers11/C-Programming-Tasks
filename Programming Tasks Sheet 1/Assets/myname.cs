using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myname : MonoBehaviour
{
    private Camera gameCamera; // Is this the simple camera controller script being refered to ?  
    public string StudentNumber = "964089"; // Is this what is meant by hard-coding? Can you hard-code in Unity?
    public string Name = "Elsa";
    private int A = 1, B = 2;

        


    // Awake is a built-in Unity function that is only called once, before the Start function
    private void Awake()
    {
        gameCamera = FindObjectOfType<Camera>();
       

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Chambers"); // This is because  the Start is called before any of the Update methods are called 
       
        Debug.Log("and my student number is");

        Debug.Log("StudentNumber"); // one-time Debug.Log containing what i hope was hardcoding in line 9

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
