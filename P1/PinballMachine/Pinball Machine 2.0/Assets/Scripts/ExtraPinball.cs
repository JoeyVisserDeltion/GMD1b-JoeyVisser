using UnityEngine;
using System.Collections;

public class ExtraPinball : MonoBehaviour {

    public float power;
    public GameObject prefab;
    public GameObject pinballSpawn;
    public bool activeBall;

    // Instantiates the ability to spawn an object
    void SpawnPinball()
    {
        GameObject pinball = (GameObject)Instantiate(prefab, pinballSpawn.GetComponent<Transform>().position, pinballSpawn.GetComponent<Transform>().rotation);

        pinball.GetComponent<Rigidbody>().velocity = pinballSpawn.GetComponent<Transform>().transform.forward * power;
    }

    // Spawns a pinball on collision except if bool: "activeBall" is true
    void OnCollisionEnter()
    {
            if (GameObject.Find("GameManager").GetComponent<GameData>().lives > 0)
            {
                if (activeBall == false)
                {
                    SpawnPinball();
                }
                else print("Nope");
            }
            else
            {
                print("GameOver");
            }

            activeBall = true;
    }
}
