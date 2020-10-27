using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutComeBiv: MonoBehaviour

{
    public TMPro.TMP_Text text_display;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Predicted outcome bc5 ->  Actual outcome = bc5 
        text_display.text = ( "bc"+(2+3)).ToString(); // Explination:  BODMAS the brackets are solved for or called upon first hence 5 then bc is called upon
    }                                                 // Question how do i excatly describe what is happening,i know  2+3 is called first but called from what the function?  
}                                                     // Continuation of question: What do i call "bc"+(2+3) is that a string? or an argument within a string? or something else? 
