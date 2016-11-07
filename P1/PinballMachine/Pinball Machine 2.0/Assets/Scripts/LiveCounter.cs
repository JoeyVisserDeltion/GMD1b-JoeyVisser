using UnityEngine;
using System.Collections;

public class LiveCounter : MonoBehaviour {

    public LivesText livesScript;
    public int balls;

    // Changes lives on collision
    void OnCollisionEnter()
    {
        livesScript.ChangeLives(balls);
    }
}
