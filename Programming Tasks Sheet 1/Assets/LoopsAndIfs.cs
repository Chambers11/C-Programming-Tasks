using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsAndIfs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 1; i <= 100; i++)
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
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    } 
}
