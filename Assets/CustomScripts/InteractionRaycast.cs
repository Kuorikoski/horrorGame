using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionRaycast : MonoBehaviour {

	public float range = 5f;
	public Image crosshair;
	public Sprite[] crosshairModels;

	public Camera cam;

	void Update ()
	{

		if (Input.GetButtonDown("Fire1"))
		{
			Interact();
		}
	}

	void Interact()
	{
		RaycastHit hit;
		if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
		{
			Debug.Log(hit.transform.name);

			if (hit.transform.tag == "grabbable")
			{
				if (hit.transform.GetComponent<GrabObject>() != null)
				{
					hit.transform.gameObject.GetComponent<GrabObject>().GrabItem();
				}
			}
			if (hit.transform.tag == "interactable")
			{
				hit.transform.gameObject.GetComponent<GrabObject>().InteractItem();

			}

            else if (hit.collider.CompareTag("Letter"))
            {
                hit.collider.GetComponent<Letter>().ShowLetterImage();
            }



			//hit.transform.GetComponent<InteractableObjectScript>();
			//InteractableObjectScript.
			//InteractableObject target = hit.transform.GetComponent<InteractableObjectScript>();
		}
	}
}
