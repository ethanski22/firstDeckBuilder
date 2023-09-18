using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Banana : MonoBehaviour
{
    public Keyboard keyboard;

    // Start is called before the first frame update
    void Start()
    {
        keyboard = Keyboard.current;
    }

    // Update is called once per frame
    void Update()
    {
        // Use * Time.deltaTime to operate in seconds instead of frames

        // Displays a message to the console tab in Unity
        // Debug.Log("Banana");

        if (keyboard == null)
        {
            Debug.LogError("No keyboard found");
        }

        if (keyboard.wKey.isPressed)
        {
            Debug.Log("You pressed the W key");
        }
    }
}
