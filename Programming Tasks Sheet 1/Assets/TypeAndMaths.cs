using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypeAndMaths : MonoBehaviour
{
    public TMPro.TMP_Text text_display;
    public string MathsResults;

    // Start is called before the first frame update
    private void Start()
    {



        // This line of code will only return whloe numbers 
        //  MathsResults = (10 / 3).ToString(); 
        MathsResults += (10 / 3f); // Once we add a floating point values after the decimal point will be reflected         

    }

    // Update is called once per frame
    void Update()
    {
        text_display.text = MathsResults;

    }
}