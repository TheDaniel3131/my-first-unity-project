using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeQuit : MonoBehaviour 
{ 
    public void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
            Debug.Log("Quit Game.");
    }
}
