using UnityEngine;
using System.Collections;

public class Char_Fire : MonoBehaviour {

    // Particles Variable
    public ParticleSystem particles;
    public int ammunitionTwo;
    public Class_Ammo ammoScriptTwo;

    // Shoots Particles on Fire
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            particles.Play();
            ammoScriptTwo.ChangeAmmoTwo(ammunitionTwo);
        }
        if (Input.GetButtonUp("Fire1"))
        {
            particles.Stop();
        }
    }
}
