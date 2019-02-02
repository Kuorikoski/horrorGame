using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;

public class Letter : MonoBehaviour {

    public Image letterImage;
    public GameObject HideLetterButton;

    public GameObject playerObject;

   public AudioClip pickUpSound;
 
	
    void Start()
    {
        letterImage.enabled = false;
        HideLetterButton.SetActive(false);
    }

 public void ShowLetterImage()
    {
        letterImage.enabled = true;
        GetComponent<AudioSource>().PlayOneShot(pickUpSound);

        HideLetterButton.SetActive(true);

        //Disable the Player - Controller
        playerObject.GetComponent<FirstPersonController>().enabled = false;

        //Unlocks the (Mouse) Cursor and make it visible
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void HideLetterImage()
    {
        letterImage.enabled = false;
       

        HideLetterButton.SetActive(false);

        //Disable the Player - Controller
        playerObject.GetComponent<FirstPersonController>().enabled = true;


        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
