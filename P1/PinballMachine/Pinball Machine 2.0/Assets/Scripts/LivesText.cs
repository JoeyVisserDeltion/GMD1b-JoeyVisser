using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LivesText : MonoBehaviour {

    public Text livesText;
    int lives = 3;

    // Shows lives and livechanges
    public void ChangeLives(int balls)
    {
        lives += balls;
        livesText.text = "" + lives;
    }
}
