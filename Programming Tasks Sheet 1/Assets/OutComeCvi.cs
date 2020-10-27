using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutComeCvi : MonoBehaviour
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
        // Predicted outcome: The string will show -4, Actual outcome: -4
        text_display.text = (4*LargestNumber).ToString(); // Explanation: Not Sure based my answer on the answer to C part 5 


    }
}
