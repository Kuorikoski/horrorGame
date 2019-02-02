using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour {

	public int enemyCaller = 0;
	public int requiredFails = 0;
	public GameObject player;
	public AudioClip heartBeat;
	public AudioClip monster;
	public GameObject enemy;
	public UnityEvent afterSpawn;
	public GameObject enemyPrefab;
	public void CallEnemy()
	{			
		player.GetComponent<AudioSource>().Stop();
		player.GetComponent<AudioSource>().PlayOneShot(heartBeat, 5);
		enemyCaller++;
		if (enemyCaller >= requiredFails)
		{	
			Instantiate(enemyPrefab,new Vector3(80,34,-58),Quaternion.identity);
			afterSpawn.Invoke();
			player.GetComponent<AudioSource>().PlayOneShot(heartBeat, 10);
			player.GetComponent<AudioSource>().PlayOneShot(monster, 10);

		}
	}

}
