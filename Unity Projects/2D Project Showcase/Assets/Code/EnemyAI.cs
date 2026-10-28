using UnityEngine;
using Pathfinding;
public class EnemyAI : MonoBehaviour
{

    /// <summary>The object that the AI should move to</summary>
    public Transform target;
    IAstarAI ai;


    public Color gizmoColor = Color.red;

    private void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    //personal code to get a radius chase
    void OnEnable()
    {
        ai = GetComponent<IAstarAI>();
        if (ai != null) ai.onSearchPath += Update;
    }

    void OnDisable()
    {
        if (ai != null) ai.onSearchPath -= Update;
    }
    public float radius = 5f;
    /// <summary>Updates the AI's destination every frame</summary>
    void Update()
    {
        if (target != null)
        {
            float distance = Vector3.Distance(transform.position, target.position);

            if (distance <= radius)
            {
                if (target != null && ai != null) ai.destination = target.position;
            }
        }
    }


}
