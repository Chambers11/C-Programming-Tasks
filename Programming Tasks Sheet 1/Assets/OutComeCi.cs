using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutComeCi : MonoBehaviour
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
        // Predicted outcome: The string will show the number 2147283647. Actual outcome:Same as predicted  
        text_display.text = (LargestNumber).ToString();


    }
}
