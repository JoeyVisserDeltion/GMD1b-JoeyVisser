using UnityEngine;
using System.Collections;

public class ScorePlaneAudio : MonoBehaviour {

    public AudioClip scorePlane;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = scorePlane;
    }

    void OnCollisionEnter()
    {
        audioSource.Play();
    }
}
