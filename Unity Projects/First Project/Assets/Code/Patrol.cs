using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using JetBrains.Annotations;
using UnityEditor.VersionControl;
using UnityEditor.Tilemaps;

public class PatrolAI : MonoBehaviour
{
    enum State { Patrol, Chase }
    //enum State are used for AI, it meant "the two moods this enemy can be in"
    State state = State.Patrol;
    //State machine - one enum {patrol, Chase} + a switch in update


    public Transform player;
    public float speed = 1f;

   
    void Start()
    {
        GameObject.FindWithTag("Player");

    }

    void Update()
    {
        switch (state)
        {
            case State.Patrol:
                Patrol();
                if (PlayerInRange()) state = State.Chase;
                break;

            case State.Chase:
                Chase();
                if (!PlayerInRange()) state = State.Chase;
                break;
        }

        //add Attack, Flee, Search -- each is just another case

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

    //walk between waypoints with Vector2.MoveTowards
    void Patrol()
    {
        Transform point = waypoints[current];
        transform.position = Vector2.MoveTowards(transform.position, point.position, patrolSpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, point.position) < 0.1f)
            current = (current + 1) % waypoints.Length;
    }
    public float stopDistance = 1f;
    //MoveTowards the player, ever frame
    void Chase()
    {
        if (Vector2.Distance(transform.position, player.position) > stopDistance)
            transform.position = Vector2.MoveTowards(
                transform.position, player.position, speed * Time.deltaTime);

        Flip(player.position.x);
    }

    //polishing - flip the sprite * stop just short of the player
    void Flip(float targetX)
    {
        float dir = targetX < transform.position.x ? -1f : 1f;
        //what does this do? uh, don't know, turns?
        transform.localScale = new Vector3(dir, 1f, 1f);
    }
}
