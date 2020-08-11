using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    PlayerHealth target;
    [SerializeField] float damge = 100f;

    void Start()
    {
        target = FindObjectOfType<PlayerHealth>();
    }
    
    public void AttackHitEvent()
    {
        if (target == null) { return; }
        target.GetComponent<PlayerHealth>().TakeDamge(damge);
        Debug.Log("bang bang");
    }
}
