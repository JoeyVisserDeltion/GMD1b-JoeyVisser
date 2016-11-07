using UnityEngine;
using System.Collections;

public class DeathZone : MonoBehaviour {

    public GameData gameDataScript;

    // Detects collision and executes lines between "{}"
    void OnCollisionEnter(Collision c)
    {
        Destroy(c.gameObject);
        gameDataScript.lives += -1;
        GameObject.Find("GameManager").GetComponent<PinballSpawn>().activeBall = false;
    }
}
