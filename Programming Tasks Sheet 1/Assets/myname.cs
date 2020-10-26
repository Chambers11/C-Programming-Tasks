using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    private Camera gameCamera; // Is this the simple camera controller script being refered to ?  
    public string StudentNumber = "964089"; // Is this what is meant by hard-coding? Can you hard-code in Unity?
    public string Name = "Chambers";
    private int A = 1;
    private int B = 2;

  
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Name); // This is because  the Start is called before any of the Update methods are called 

        Debug.Log("and my student number is");

        Debug.Log(StudentNumber); // one-time Debug.Log containing what i hope was hardcoding in line 9

        Debug.Log("A" + A + "B" + B);

      

        SwapValues();
        Debug.Log("A" + A + "B" + B);
        SwapValues();
        Debug.Log("A" + A + "B" + B);

    }

    private void SwapValues()
        // Values of A and B have been presevered. 
        // All these commments are for the first time you call  SwapValues 
       //  Steve " Imagine you have two beers in your hand and you are trying to swap them, you can do it simlultaniously, you need to put one down on the table... "
      
    {
        int Temp = A; // Temp is equal to 1 
        A = B; // A is set to 2 
        B = Temp; // B now equals 1 
        

    }


    private static void Update()
    {

    }
}
