using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;
    
    public void TakeDamge(float damage)
    {
        hitPoints -= damage;

        if (hitPoints <= 1)
        {
            Debug.Log("You dead, my glip glop");
            GetComponent<DeathHandler>().HandleDeath();
        }
    }
}
