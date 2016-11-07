using UnityEngine;
using System.Collections;

public class TowerAudio : MonoBehaviour {

    public AudioClip tower;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = tower;
    }

    void OnCollisionEnter()
    {
        audioSource.Play();
    }
}
