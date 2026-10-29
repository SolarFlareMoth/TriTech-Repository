using Pathfinding;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform target;
    IAstarAI ai;
    //this grabs an interface from Pathfinding

    //below is how to show the radius within unity, I can elaborate more in Testing Script
    public Color gizmoColor = Color.red;

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    //showing the radius end

    //if enabled, it will grab the AI from Pathfinding
    void OnEnable()
    {
        ai = GetComponent<IAstarAI>(); // dont mind he grey here, it doesn't matter
        if (ai != null) ai.onSearchPath += Update;
    }

    void OnDisable()
    {
        if (ai != null) ai.onSearchPath -= Update;
    }

    //some of this is also part of the radius, this makes the radius do something
    //instead of just showing it has one 
    public float radius = 5f;

    void Update()
    {
        
        
        if (target != null)
        {
            float distance = Vector3.Distance(transform.position, target.position);

            //if its inside the radius we set, make it public so it can change
            if (distance <= radius)
            {
                if (target != null && ai != null) ai.destination = target.position;
            }
        }
        //will continue moving a bit after losing them, it doesn't "completely" diable it's movement
        //it disables the ability to pathfind to the player, so they just sit there
    }
}
