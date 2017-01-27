using UnityEngine;
using System.Collections;

public class Char_Fire : MonoBehaviour {

    // Particles Variable
    public ParticleSystem particles;

    // Shoots Particles on Fire
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            particles.Play();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            particles.Stop();
        }
    }
}
