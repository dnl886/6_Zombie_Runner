﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float range = 100f;
    [SerializeField] float damage;
    [SerializeField] ParticleSystem muzleFlash;
    [SerializeField] GameObject hitFX;

    [SerializeField] ammo ammoSlot;
    [SerializeField] float timeBetweenShots = .05f;


    bool canShoot = true;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canShoot == true)
        {
            StartCoroutine (Shoot());
        }
    }

    IEnumerator Shoot()
    {
        canShoot = false;
        if(ammoSlot.GetCurrentAmmo() > 0)
        {
            PlayMuzzleFlash();
            ProcessFiring();

            ammoSlot.ReduceAmmo();
        }

        yield return new WaitForSeconds(timeBetweenShots);

        canShoot = true;
    }

    void PlayMuzzleFlash()
    {
        muzleFlash.Play();
    }
    void ProcessFiring()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, range))
        {
            CreateHitImpact(hit);
            EnemyHealth target = hit.transform.GetComponent<EnemyHealth>();
            if (target == null) return;
            target.TakeDamage(damage);
        }
        else 
        {
            return;
        }
    }

    void CreateHitImpact(RaycastHit hit)
    {
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //if (hit.collider != null) //This adds lights to objects when u shootat it lol

        GameObject impact = Instantiate(hitFX, hit.point, Quaternion.LookRotation(hit.normal));
        Destroy(impact, .1f);
    }

}
