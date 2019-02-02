using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heartbeat : MonoBehaviour {

    public AudioClip eventHeartBeat;
    AudioSource audio;
    private bool triggerOnce = true;
    public float volume = 5f;

     void Start()
    {
       audio = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (triggerOnce)
        {
            audio.PlayOneShot(eventHeartBeat, volume);
            triggerOnce = false;
        }
    }



}


