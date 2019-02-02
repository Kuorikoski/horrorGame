// ToggleLight.cs
// Turns the light component of this object on/off when the user presses and releases the `L` key.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleHalo : MonoBehaviour
{

    Behaviour halo;


    void Start()
    {
        halo = (Behaviour)GetComponent("Halo");
    }

    void OnMouseOver()
    {

        halo.enabled = true;
    }

    void OnMouseExit()
    {

        halo.enabled = false;
    }



}
