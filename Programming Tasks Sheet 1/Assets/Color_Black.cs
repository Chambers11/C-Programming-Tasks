using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Black : MonoBehaviour
{
    // Question a: 
    public TMPro.TMP_Text text_display;
    public enum CurrentColor { black, white, blue, green };

    // Question b: 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        text_display.color = Color.black;
    }
}
