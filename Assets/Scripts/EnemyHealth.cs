﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float hitPoints =100f;
    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        if (hitPoints <= 1)
        {
            Destroy(gameObject);
        }
    }
}
