using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int EnemyHP = 2;
    public GameObject healthPack;
    public GameObject ammoPack;
    public GameObject SmallCoin;
    public GameObject BigCoin;
    //store hp as a variable
    //if the enemy hits a player bullet, reduce hp
    //if hp <= 0, they die
    //below is for triggers, OnCollisionEnter will not work for triggers
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enemy hit " + collision.gameObject.name);
        if (collision.gameObject.tag == "Bullet")
        {
            EnemyHP -= 1;
        }
        if (collision.gameObject.tag == "Fireball")
        {
            EnemyHP -= 2;
        }
        if(EnemyHP <=0)
        {

            Debug.Log("Enemy Down");
            Destroy(gameObject);
            int r = Random.Range(1, 21);
            if (r>=15)
            {
                Instantiate(healthPack, transform.position, Quaternion.identity);
                Debug.Log(r);
            }
                if (r<=10)
                {
                    Instantiate(ammoPack, transform.position, Quaternion.identity);
                    Debug.Log(r);
                }
                if (r>10 && r<=12)
                {
                    Instantiate(SmallCoin, transform.position, Quaternion.identity);
                }
                if (r > 12 && r < 15)
                {
                    Instantiate(BigCoin, transform.position, Quaternion.identity);
                }
            //CHALLENGE:
            //modify enemy health to have A CHANCE of dropping a health pack object
            //create a new script on the player bullet to destroy the player bullet
            //when it hit anything whose tag != (not equal) to the player
        }
    }

}
