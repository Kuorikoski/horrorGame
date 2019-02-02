using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DelayTimer : MonoBehaviour {
	
	public float delay = 0f;
	public bool startOnAwake = false;

	public UnityEvent delayTimerEvent;
	public void Awake()
	{
		if (startOnAwake == true)
		{
			StartCoroutine(WaitTimer());
		}
	}

	public void TriggerWaitTimer()
	{
		StartCoroutine(WaitTimer());
	}

	public IEnumerator WaitTimer()
	{
		yield return new WaitForSeconds(delay);
		delayTimerEvent.Invoke();
	}
}
