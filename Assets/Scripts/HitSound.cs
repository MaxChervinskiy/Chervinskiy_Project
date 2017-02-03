using UnityEngine;
using System.Collections;
using System;
[RequireComponent(typeof(AudioSource))]
public class HitSound : MonoBehaviour,IHittble {
    public AudioClip clip;

    public void hit()
    {
       // GetComponent<AudioSource>().PlayOneShot(clip);
    }

    
}
