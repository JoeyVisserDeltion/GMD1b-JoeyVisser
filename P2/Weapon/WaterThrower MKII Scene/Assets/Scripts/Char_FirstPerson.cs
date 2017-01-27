using UnityEngine;
using System.Collections;

public class Char_FirstPerson : MonoBehaviour {

    // Jump Variables
    public Vector3 jumpVelocity;
    public Rigidbody rb;
    public int jumpAmount;

    // Rotation Variables
    public Vector3 rotation;
    public Vector3 camRotation;
    public GameObject cam;
    public int camSpeedVer;
    public int camSpeedHor;

    // Movement Variables
    public Vector3 charMovement;
    public float hor;
    public float ver;
    public int speed;

    // Resets Jump
    void OnCollisionEnter()
    {
        jumpAmount = 0;
    }

    // Character Movement (Jumping, Camera, Walking)
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            jumpAmount = jumpAmount + 1;

            if (jumpAmount < 2)
            {
                rb.velocity = jumpVelocity;
            }
        }

        rotation.y = Input.GetAxis("Mouse X");
        camRotation.x = -Input.GetAxis("Mouse Y");

        transform.Rotate(rotation * camSpeedHor * Time.deltaTime);
        cam.transform.Rotate(camRotation *camSpeedVer * Time.deltaTime);

        hor = Input.GetAxis("Vertical");
        ver = -Input.GetAxis("Horizontal");

        charMovement.x = hor;
        charMovement.z = ver;

        transform.Translate(charMovement * speed * Time.deltaTime);
    }
}
