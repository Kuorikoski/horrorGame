using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDirector : MonoBehaviour {
	public GameObject inventory;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("tab"))
		{
			inventory.SetActive(true);
		}
		if (Input.GetKeyUp("tab"))
		{
			inventory.SetActive(false);
		}		
	}
}
