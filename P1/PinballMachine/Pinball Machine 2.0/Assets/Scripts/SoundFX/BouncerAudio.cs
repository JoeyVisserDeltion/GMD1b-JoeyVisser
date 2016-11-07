using UnityEngine;
using System.Collections;

public class BouncerAudio : MonoBehaviour {

    public AudioClip bouncer;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bouncer;
    }

    void OnCollisionEnter()
    {
        audioSource.Play();
    }
}
