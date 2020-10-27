using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloTextMeshPro : MonoBehaviour
{
    public TMPro.TMP_Text text_display;
    public string Name;

    // Start is called before the first frame update.
    void Start()
    {
        // The Name display in editor doesn't allow you to change the Name once the program has been started becase the Start is called just before any of the Update methods.  
        text_display.text = Name;


    }

    // Update is called once per frame
    void Update()
    {
        // The Name display in editor  now allows you to change the Name once the program has been started, this is because Update is called every frame, if Mono behaviour is enabled.   
        text_display.text = Name;
    }
}
