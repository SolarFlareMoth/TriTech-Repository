using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public GameObject healthPack;
    public GameObject ammoPack;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health--;

            if (health <=0)
            {
                Destroy(gameObject);

                int r = Random.Range(1, 21);
                if (r >= 11)
                {
                    Instantiate(healthPack, transform.position, Quaternion.identity);
                    Debug.Log(r);
                }
                if (r <= 10)
                {
                    Instantiate(ammoPack, transform.position, Quaternion.identity);
                    Debug.Log(r);
                }
            }
        }
    }
}
