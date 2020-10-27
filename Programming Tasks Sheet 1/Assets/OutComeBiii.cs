using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutComeBiii : MonoBehaviour

{
    public TMPro.TMP_Text text_display;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Predicted outcome 5bc ->  Actual outcome = 5bc 
        text_display.text = ((2 + 3) + "bc").ToString(); // Explanation BODMAS the brackets are solved for or called upon first hence 5 then bc is called upon
    }
}
