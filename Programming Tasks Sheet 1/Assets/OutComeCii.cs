using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutComeCii : MonoBehaviour
{
    public TMPro.TMP_Text text_display;
    public int LargestNumber = 2147483647;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Predicted outcome: The string will show and error message, Actual outcome: -2147483648  
        text_display.text = (LargestNumber+1).ToString(); // Explanation: based on an assumption, the max vaule is being in a form that allows the code LargestNumber + 1 to run. 


    }
}
