using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour {

    // Item variable
    public string item;

    // Pick up item
    void OnCollisionEnter()
    {
        print(item);
        Destroy(gameObject);
    }
}
