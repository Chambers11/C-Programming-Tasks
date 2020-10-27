using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class IfStatement : MonoBehaviour
{
    public int A = 1;
    public int B = 2;
    public int C;



    // Question a & b:
    // NB: if statements can be used anywhere, most commonly they are found in the Update method 
    private void Update()
    {
        if (A < B)
        { 
            Debug.Log("True");
        }
        else if (A > B)
        {
            Debug.Log("False");
        }
    // Question c: (I understand what being asked, but don't know how to set it out, ask next time.) 

    // Question d: 
    // The % or modulo operator allows one to asses if number are odd or even it does so by dividing values by 2 and if the remainder = 0 then the number is even if the remainder is of 1 then the number is odd

        if (C % 2 == 0)
        {
            Debug.Log("Even");
        }

        else if (C % 2 == 1)
        {
            Debug.Log("Odd");
        }


       
    }

    
}