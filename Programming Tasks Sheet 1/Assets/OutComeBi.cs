using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutComeBi : MonoBehaviour

{
    public TMPro.TMP_Text text_display;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Predicted outcome 2bc ->  Actual outcome = 2bc 
        text_display.text = (2 +"bc").ToString(); 
    }
}
