using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Controller : MonoBehaviour {

    // Variables for movement
    public Vector3 movement;
    public float hor;
    public float ver;
    public float speed;

    // Variables for rotation
    public Vector3 rotation;
    public Vector3 camRotation;
    public GameObject cam;
    public float camSpeed;

    // Movement + Rotation
    void FixedUpdate()
    {
        // Movement
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        movement.x = hor;
        movement.z = ver;

        transform.Translate(movement * speed * Time.deltaTime);

        // Rotation
        rotation.y = Input.GetAxis("Mouse X");
        camRotation.x = Input.GetAxis("Mouse Y");

        transform.Rotate(rotation * camSpeed * Time.deltaTime);
        transform.Rotate(-camRotation * camSpeed * Time.deltaTime);
    }
}
