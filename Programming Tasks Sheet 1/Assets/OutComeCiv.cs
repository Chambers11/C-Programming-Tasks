using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutComeCiv : MonoBehaviour
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
        // Predicted outcome: The string will show 2147483649, Actual outcome: 2147483647 
        text_display.text = (-2 - LargestNumber).ToString(); // Explanation: The LargestNumber is as big as it can be in both the negative and positve side of the number line

    }
}
