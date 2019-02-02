using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorOpener : MonoBehaviour {

	public bool[] keys;
	public int requiredKey = 0;
	public AudioSource doorLocked;
	public AudioSource doorUnlocked;
	public Animator loadScene;

	public void OpenDoor()
	{
		if (keys[requiredKey] == true)
		{
			doorUnlocked.Play();
			loadScene.Play("dismissScene");
			StartCoroutine(LoadNextScene());
		}
		else
		{
			doorLocked.Play();
		}
	}
	public void PickUpKey()
	{
		keys[0] = true;
	}
	public IEnumerator LoadNextScene()
	{
		yield return new WaitForSeconds(2f);
		SceneManager.LoadScene(2);
	}

}
