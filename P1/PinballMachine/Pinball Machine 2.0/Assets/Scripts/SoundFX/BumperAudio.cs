using UnityEngine;
using System.Collections;

public class BumperAudio : MonoBehaviour {

    public AudioClip bumper;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bumper;
    }

    void OnCollisionEnter()
    {
        audioSource.Play();
    }
}
