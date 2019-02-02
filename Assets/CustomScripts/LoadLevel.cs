using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour {

	public int levelToLoad = 0;
	public void LoadLevelInt()
	{
		SceneManager.LoadScene(levelToLoad);
	}
}
