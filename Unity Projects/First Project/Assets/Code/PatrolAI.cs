using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using JetBrains.Annotations;

public class Patrol : MonoBehaviour
{
    public Transform player;
    public float speed = 1f;

   
    void Start()
    {
        GameObject.FindWithTag("Player");

    }
    void Update()
    {

        transform.position = Vector2.MoveTowards(
            transform.position, player.position, speed * Time.deltaTime);
        //where the enemy is now, where the player is, and how far to move this frame

        
    }

    public float detectRange = 5f;

    bool PlayerInRange()
    {
        float dist = Vector2.Distance(transform.position, player.position);
        return dist < detectRange;

        //something it added was "Or raycast with Physics2D for true line-of-sight
    }

    public Transform[] waypoints;
    public float patrolSpeed = 2f;
    int current = 0;

    void Patroling()
    {
        Transform point = waypoints[current];
        transform.position = Vector2.MoveTowards(transform.position, point.position, patrolSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, point.position) < 0.1f)
            current = (current + 1) % waypoints.Length;
    }
}
