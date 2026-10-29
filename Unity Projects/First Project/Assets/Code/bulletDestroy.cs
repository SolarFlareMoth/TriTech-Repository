using UnityEngine;

public class bulletDestroy : MonoBehaviour
{
    //entering a trigger deletes object
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

    //entering collision deletes object
    private void OncolliderEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
