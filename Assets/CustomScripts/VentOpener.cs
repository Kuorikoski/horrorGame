using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentOpener : MonoBehaviour {

	public GameObject leftBolt;
	public GameObject rightBolt;
	public Animator ventFall;
	public AudioSource ventSound;
	public AudioSource ventOpeningSound;

	public void OpenVent()
	{
		if (leftBolt.tag == "Untagged" && rightBolt.tag == "Untagged")
		{
			ventFall.Play("ventHinge");
			gameObject.tag = "Untagged";
			ventOpeningSound.Play();
			StartCoroutine(WaitForSound());
		}
	}
	public IEnumerator WaitForSound()
	{
		yield return new WaitForSeconds(1.35f);
		ventSound.Play();
	}
}
