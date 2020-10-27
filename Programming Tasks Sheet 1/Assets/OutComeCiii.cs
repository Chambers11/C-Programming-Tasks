using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutComeCiii : MonoBehaviour
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
        // Predicted outcome: The string will show -2147483645, Actual outcome: -2147483645 
        text_display.text = (2-LargestNumber).ToString(); // Explanation: general rules of maths 


    }
}
