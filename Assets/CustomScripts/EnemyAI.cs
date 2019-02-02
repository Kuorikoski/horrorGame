using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour 
{
	public Transform character;
	public float speed;
	public float killDistance;
	public float maxDistance;
	public Animator loadScene;
	public GameObject player;
	void Start()
	{
		character = Camera.main.transform;
		loadScene = GameObject.FindGameObjectWithTag("sceneloader").GetComponent<Animator>();
		speed = 2;
		killDistance = 0.1f;
		maxDistance = 10;
		player = GameObject.Find("FPSController");
	}
	void Update () 
 	{  
		transform.LookAt(character);  
		if(Vector3.Distance(transform.position,character.position) >= killDistance && Vector3.Distance(transform.position,character.position) < maxDistance)
		{
			transform.position += transform.forward*speed*Time.deltaTime;     
		}
		if (Vector3.Distance(transform.position,character.position) < killDistance)
		{
			player.GetComponent<CharacterController>().enabled = false;
			loadScene.Play("dismissScene");
			StartCoroutine(LoadNewScene());
		} 
		if ( Vector3.Distance(transform.position,character.position) > maxDistance)
		{
			gameObject.SetActive(false);
		}
    }
	public IEnumerator LoadNewScene()
	{
		yield return new WaitForSeconds(3);
		SceneManager.LoadScene(1);
	}
 }

