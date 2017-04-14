using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationManager : MonoBehaviour {

    // Options variables
    public bool optionOne;
    public bool optionTwo;

    // Custom text variables
    public string one;
    public string two;

    public string mainText;

    // Trigger conversation
    void OnCollisionEnter()
    {
        print(mainText);
    }

    // Choose options via bool
    void Update()
    {
        if(optionOne == true)
        {
            print(one);
            optionOne = false;
        }

        if(optionTwo == true)
        {
            print(two);
            optionTwo = false;
        }
    }
}
