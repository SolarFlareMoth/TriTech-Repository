using JetBrains.Annotations;
using Unity.VisualScripting;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class PlayerHealth : MonoBehaviour
{
    //om nom nom nom
    //when you lose all hp you die
    //store hp in a variable
    //if we hit an eenmy, reduce hp, if hit 0 then die
    //when we die, reload current level
    void Start()
    {
        healthText.text = "Health: " + health;
        //CHALLENGE:
        //update your player collectable code (?) to display how many collectables you have

        //change player shoot to have a fixed amount of ammo. display ammo count on the canvas, don't shoot if you dont have ammo
    }
    public int health = 100;
    //the text object I want to update to display my current health
    public TMP_Text healthText;

    public GameObject healthPack;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("I hit something");
        Debug.Log(collision.gameObject.name);
        //health --;
        // = means is, or sets a value, == means compare the value to give true or false
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("I hit an enemy!");
            health -= 10;
            //update my health text to match my new current HP value
            healthText.text = "Health: " + health;
            if (health <= 0)
            {
                Debug.Log("haha, im in danger -Ralphie Wiggums");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("healthPack") && health <=199)
        { 
                health += 10;
                Destroy(healthPack);
                healthText.text = "Health: " + health;
                Debug.Log("health up!");
            
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("I hit an enemy!");
            health -= 10;
            //update my health text to match my new current HP value
            healthText.text = "Health: " + health;
            if (health <= 0)
            {
                Debug.Log("haha, im in danger -Ralphie Wiggums");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }
    }
    //example
    private void Example()
    {

    }
}

