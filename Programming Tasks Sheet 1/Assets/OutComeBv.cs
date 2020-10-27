using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutComeBv : MonoBehaviour

{
    public TMPro.TMP_Text text_display;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {      
        // Predicted outcome bc5 ->  Actual outcome = bc23  
        text_display.text = ( "bc"+ 2 + 3 ).ToString(); // Explination the order in which the function is called upon is based on BODMAS thus
                                                        // 2 and 3 are not called upon as interger values, but as strings from the argument? 
    }
}
