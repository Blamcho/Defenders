using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    public int health = 3;
    private Transform target;
    private int waypointIndex = 0;

    void Start()
    {
        target = Waypoints.points[waypointIndex];
    }

    void Update()
    {
        MoveTowardsWaypoint();
    }

    void MoveTowardsWaypoint()
    {
        if (target == null) return;

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, target.position) < 0.2f)
        {
            GetNextWaypoint();
        }
    }

    void GetNextWaypoint()
    {
        if (waypointIndex >= Waypoints.points.Length - 1)
        {
            Destroy(gameObject); // Enemigo llega al final y desaparece
            return;
        }

        waypointIndex++;
        target = Waypoints.points[waypointIndex];
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

