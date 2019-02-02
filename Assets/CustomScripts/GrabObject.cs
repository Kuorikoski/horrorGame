using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GrabObject : MonoBehaviour {

	public Transform player;
    public Transform playerCam;
    public float throwForce = 10;
    public static bool hasPlayer = false;
    bool beingCarried = false;
    public int dmg;
    private bool touched = false;

	public bool notGrabbable;
	public UnityEvent afterEffectsEvents;
	

    void Update()
    {
        if (hasPlayer && notGrabbable == false)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = playerCam;
            beingCarried = true;
        }
        if (beingCarried)
        {
            if (touched)
            {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                touched = false;
				hasPlayer = false;
				Debug.Log("Drop");
            }
            if (Input.GetMouseButtonDown(0))
                {
                    GetComponent<Rigidbody>().isKinematic = false;
                    transform.parent = null;
                    beingCarried = false;
                    GetComponent<Rigidbody>().AddForce(playerCam.forward * throwForce);
                }
                else if (Input.GetMouseButtonDown(1))
                {
                GetComponent<Rigidbody>().isKinematic = false;
                transform.parent = null;
                beingCarried = false;
                }
            }
        }

		public void GrabItem()
		{
			hasPlayer = true;
			Debug.Log("ItemGrabbed");
		}

		public void InteractItem()
		{
			afterEffectsEvents.Invoke();
		}

   
   void OnTriggerEnter()
    {
        if (beingCarried)
        {
            touched = true;
        }
    }
}

