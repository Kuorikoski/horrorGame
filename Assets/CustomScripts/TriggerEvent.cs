using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour {

	public UnityEvent eventSystem;

	public void OnTriggerEnter(Collider other)
	{
		eventSystem.Invoke();
	}
}
