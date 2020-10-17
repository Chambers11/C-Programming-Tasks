using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourExample : MonoBehaviour
{
    private Camera gameCamera; // the game camera pointing at objects

        // Awake, this is a built-in Unity function that is only called upon once, before the Start function 
    private void Awake() //Awake is called when the script instance is being loaded
    {
        Debug.Log("Awake");

        // find the camera in the scene and store for later 
        gameCamera = FindObjectOfType<Camera>();
    }
        // Start is called before the first frame update
    private void Start() // Start is called just before any of the Update methods are called for the first time 
    {
        Debug.Log("Started");

    }

       // Update is called once per frame
    private void Update() // Update is called every frame, if MonoBehaviour is enabled 
    {
        Debug.Log("Update");
    }
      
    private void FixedUpdate() // This function is called every fixed framerate frame, if the MonoBehaviour is enabled 
    {
        Debug.Log("Fixed update");
 
    

    }
}

