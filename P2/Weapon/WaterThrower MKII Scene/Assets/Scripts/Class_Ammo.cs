using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Class_Ammo : MonoBehaviour {

    // Ammo capacity variable
    public int ammo;
    public Text ammoText;

    // Display Ammo and increase/decrease ammo
    public void ChangeAmmo(int ammunition)
    {
        ammo += ammunition;
        ammoText.text = "" + ammo;
    }

    public void ChangeAmmoTwo(int ammunitionTwo)
    {
        ammo -= ammunitionTwo;
        ammoText.text = "" + ammo;
    }
}
