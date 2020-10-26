using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMesh3Arguments : MonoBehaviour
{
    public TMPro.TMP_Text TextDisplay; // Displays the TextDisplay feature in editor 
    public string NameFirst, NameSecond, NameThrid; // This line is the method used to create 3 public strings 

    // Creation of 3 arguments using the below method  
    void Hello3(string First, string Second, string Third)
    {
        TextDisplay.text = "Hello" + First + "," + Second + "and" + Third;  // This is called string concatenation 
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hello3(NameFirst, NameSecond, NameThrid);  // This allows us to update the name variables in editor during runtime 

    }
}
