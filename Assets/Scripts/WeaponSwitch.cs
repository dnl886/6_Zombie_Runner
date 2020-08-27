using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    [SerializeField] int currentweapon = 0;
    void Start()
    {
        SetWeaponActive();
    }

    private void SetWeaponActive()
    {
        int weaponIndex = 0;

        foreach(Transform weapon in transform)
        {
            if(weaponIndex == currentweapon)
            {
                weapon.gameObject.SetActive(true);
            }
            else 
            {
                weapon.gameObject.SetActive(false);
            }
            weaponIndex++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
