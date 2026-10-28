using UnityEngine;

public class BulletBreak : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //for rotating the bullet
        //transform.right = Vector2.Lerp(transform.forward, rb.linearVelocity, Time.deltaTime);
        
        //ok so dont need that for bullet rotation anymore
    }

    

    private void LateUpdate()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        { 
            //for (int i = 0; i < 4; i++)
            //{
               // if (i >=4)
                //{
                    Destroy(gameObject); //piramid size code
                //}
           // }
        }  
    }
}
