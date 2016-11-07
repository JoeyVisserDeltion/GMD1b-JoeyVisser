using UnityEngine;
using System.Collections;

public class WallAudio : MonoBehaviour {

    public AudioClip wall;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = wall;
    }

    void OnCollisionEnter()
    {
        audioSource.Play();
    }
}
