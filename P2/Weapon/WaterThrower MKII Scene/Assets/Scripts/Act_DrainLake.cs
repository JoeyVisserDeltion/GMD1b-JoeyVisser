using UnityEngine;
using System.Collections;

public class Act_DrainLake : MonoBehaviour {

    // Lake Variable
    public GameObject lake;

    // OnCollison Drain Lake
    void OnCollisionEnter()
    {
        Destroy (lake);
    }
}
