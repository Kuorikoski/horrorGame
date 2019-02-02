// ToggleLight.cs
// Turns the light component of this object on/off when the user presses and releases the `L` key.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{

    Light light;

    
    void Start()
    {
        light = GetComponent<Light>();
    }

    void OnMouseOver()
    {
        
        light.enabled = true;
    }

    void OnMouseExit()
    {
       
        light.enabled = false;
    }


 
}
