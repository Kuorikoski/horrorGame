using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWheel : MonoBehaviour {

	public GameObject[] wheels;
    public AudioSource audio;

	public int[] currentCombination = new int[4];
	public int[] correctCombination = new int[4] {1,2,3,4};

	private float currAngle = -250;
	public Vector3[] wheelAngles = new Vector3[4];

	public Animator leverAnimation;
	public Animator paintingAnimation;

	public void TurnWheelClock(int wheelNumber)
	{
        audio.Play();
		wheelAngles[wheelNumber] = new Vector3(currAngle - (36 * (currentCombination[wheelNumber] + 1)), 0, -90);
		Quaternion rotQuater = Quaternion.Euler(wheelAngles[wheelNumber]);
		wheels[wheelNumber].transform.localRotation = rotQuater;
		switch (wheelNumber)
		{
			case 0:
				currentCombination[0] += 1;
				if (currentCombination[0] == 10)
				{
					currentCombination[0] = 0;
				}
				if (true)
				{
					
				}
				break;
			case 1:
				currentCombination[1] += 1;
				if (currentCombination[1] == 10)
				{
					currentCombination[1] = 0;
				}
				break;
			case 2:
				currentCombination[2] += 1;
				if (currentCombination[2] == 10)
				{
					currentCombination[2] = 0;
				}
			break;	
			case 3:
				currentCombination[3] += 1;
				if (currentCombination[3] == 10)
				{
					currentCombination[3] = 0;
				}
			break;
		}
	}

	public void SolvePuzzle()
	{

			if (currentCombination[0] == correctCombination[0] && currentCombination[1] == correctCombination[1] && currentCombination[2] == correctCombination[2] && currentCombination[3] == correctCombination[3])
			{
				leverAnimation.Play("puzzleLever");
				paintingAnimation.Play("paintingSlidingAway");
			}

		
		
	}
}
