using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myname : MonoBehaviour
{
    private Camera gameCamera; // Is this the simple camera controller script being refered to ?  
    public string myName = "964089"; //  ??is this what is meant by hard-coding? Can you hard-code in Unity?
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
        Debug.Log("and my student number is");

        Debug.Log("myName"); // one-time Debug.Log conttaning what i hope was hardcoding in line 9 

        Debug.Log("Chambers"); // because  the Start is called before any of the Update methods are called 
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
