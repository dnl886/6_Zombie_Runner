using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo : MonoBehaviour
{
    [SerializeField] int ammoAmount = 5;

    public int GetCurrentAmmo()
    {
        return ammoAmount;
             
    }

    public void ReduceAmmo()
    {
        ammoAmount--;
    }
}
