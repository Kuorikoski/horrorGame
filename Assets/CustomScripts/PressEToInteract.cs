using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class PressEToInteract : MonoBehaviour {

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject ActionText;
    public GameObject GameObject;
    

	// Update is called once per frame
	void Update () {

        TheDistance = PlayerCasting.DistanceFromTarget;
		
	}


    void OnMouseOver ()
    {
       if (TheDistance <= 3)
        {
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

    }

    void OnMouseExit() { 
        ActionDisplay.SetActive(false);
        ActionText.SetActive(false);
    }
}
