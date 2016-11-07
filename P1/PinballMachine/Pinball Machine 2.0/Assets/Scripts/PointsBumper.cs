using UnityEngine;
using System.Collections;

public class PointsBumper : MonoBehaviour {

    public ScoreText scoreScript;
    public int points;

    // Makes score happen
    void OnCollisionEnter()
    {
        scoreScript.ChangeScore(points);
    }
}
