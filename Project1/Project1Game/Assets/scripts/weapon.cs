using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int maxAmmo = 6;
    public int currAmmo;
    public float reload = 2f;
    private bool isReloading = false;

    void Start()
    {
        currAmmo = maxAmmo;
    }

    void Update()
    {
        if (isReloading)
            return;
        if (currAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    IEnumerator Reload()
    {
        isReloading = true;
        yield return new WaitForSeconds(reload);
        currAmmo = maxAmmo;
        isReloading = false;
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        currAmmo --;

    }


}

