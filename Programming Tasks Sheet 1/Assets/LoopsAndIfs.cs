using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsAndIfs : MonoBehaviour
{
    // Start is called before the first frame update
    // This version of code according to Tom Scott is bad practice if you choose to make the section of code larger becuase if you want the game to work for multiples of 7 you'd have to manual change all the numbers e.g. 5 to 7!!
  private  void Start()
    {
      /*  for (var i = 1; i <= 100; i++)
        {
            if ((i%3== 0) && (i%5==0))
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else
            {
                Debug.Log(i);
            }*/
      // Based on what Tom Scott said this is a better way of writing code for the FizzBuzz game, as it allows you to easiy change the multiples from 5 to 7 to any number really.It also allows you to add more numbers
      for (var i = 1; i <= 100; i++)
        {
            var output = ""; 
            if (i % 3 == 0)
            {
                output += "Fizz";
            }
            if (i % 5 == 0)
            {
                output += "Buzz";
            }
           if (output == "") 
            {
                // Had to use .ToString() to allow output string to accept int i (Not sure why it worked but it did)
                output = (i).ToString();
                
            }
                Debug.Log(output);
        } 
    }

        // Update is called once per frame
        void Update()
        {

        }
    } 

