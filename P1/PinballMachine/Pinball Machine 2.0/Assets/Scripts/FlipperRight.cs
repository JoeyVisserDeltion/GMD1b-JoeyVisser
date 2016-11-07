using UnityEngine;
using System.Collections;

public class FlipperRight : MonoBehaviour {

    public float flipperStrength;
    public float pushForce;
    private HingeJoint hinge;
    public AudioClip flipper;
    private AudioSource audioSource;

	// Use this to grab the HingeJoint and AudioSource
	void Start ()
    {
        hinge = GetComponent<HingeJoint>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = flipper;
    }
	
    // Triggers flipper on buttonpress
	void FixedUpdate ()
    {
        if (Input.GetButtonDown("Right"))

        {
            Vector3 f = -transform.up * flipperStrength;
            Vector3 p = (transform.right) + transform.position * pushForce;
            GetComponent<Rigidbody>().AddForceAtPosition(f, p);
            audioSource.Play();
        }
	
	}
}
