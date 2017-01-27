using UnityEngine;
using System.Collections;

public class Act_DrainLake : MonoBehaviour {

    // Lake Variable
    public GameObject lake;
    public Class_Ammo ammoScript;
    public int ammunition;

    // OnCollison Drain Lake and add ammo
    void OnCollisionEnter()
    {
        Destroy (lake);
        ammoScript.ChangeAmmo(ammunition);
    }
}
