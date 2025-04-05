using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    private Transform target;

    void Update()
    {
        if (target == null) return;

        if (fireCountdown <= 0f)
        {
            Shoot();
            fireCountdown = 1f / fireRate;
        }
        fireCountdown -= Time.deltaTime;
    }

    void Shoot()
    {
        GameObject bulletGO = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletGO.GetComponent<Bullet>();
        if (bullet != null)
        {
            bullet.Seek(target);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            target = other.transform;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.transform == target)
        {
            target = null;
        }
    }
}