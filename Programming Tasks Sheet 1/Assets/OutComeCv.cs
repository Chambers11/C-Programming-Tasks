using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutComeCv : MonoBehaviour
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
        // Predicted outcome: The string will show 2147483647, Actual outcome: -2
        text_display.text = (2*LargestNumber).ToString(); // Explanation: I'm not sure 


    }
}
