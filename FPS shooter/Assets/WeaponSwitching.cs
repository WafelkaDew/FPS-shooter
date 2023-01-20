
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public int selectedWeapon = 0;

    private int weaponCount;
    void Start()
    {
        weaponCount = transform.childCount;

        SelectedWeapon();
    }

    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
        {
            if (selectedWeapon < weaponCount-1)
            {
                selectedWeapon++;
                SelectedWeapon();

            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
        {
            if (selectedWeapon > 0)
            {
                selectedWeapon--;
                SelectedWeapon();

            }
        }
    }

    void SelectedWeapon ()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
