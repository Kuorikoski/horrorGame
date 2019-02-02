using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionForAnimation : MonoBehaviour {

	public Transform main;
	public Transform player;

	private Vector3 mainCameraStartPos;
	private Vector3 playerStartPos;

	// Use this for initialization
	void Start () {
		mainCameraStartPos = main.position;
		playerStartPos = player.position;

	}

	public void ResetPositions()
	{
		player.position = playerStartPos;
		player.eulerAngles = new Vector3(0,90,0);

	}
}
