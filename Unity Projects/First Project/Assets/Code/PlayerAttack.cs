using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerAttack : MonoBehaviour
{
    //OnAttack will get callled whenever the Attack buttons are pressed
    //create a new copy of the player bullet object
    //push the bullet in the direction of the mouse
    //destroy the bullet after a few seconds to keep the level clean
    public GameObject bullet;
    public float BulletSpeed = 2f;
    //create my ammo variable
    public int ShotCount;
    public TMP_Text shotText;

    void Start()
    {
        shotText.text = "Shots: " + ShotCount;
        ShotCount = 14;
    }
    public void OnAttack()
    {
        //we only want to shoot if we have ammo AND the game isn't paused
        //we can use the symbol && to combine two different conditions
        if (ShotCount > 0 && Time.timeScale == 1)
        {
            ShotCount--;
            //hold alt and use arrows to move things!
            GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
            Destroy(shot, 5);
            //Our Equation for the shoot direction is Destination - Starting pos
            //in this case, we want to start at the player, end up at the mouse
            //first we need to find where the mouse is on screen
            Vector3 mousePos = Mouse.current.position.ReadValue();
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            Debug.Log(mousePos);
            //Readvalue will never be negative since it's reading out input from our pixel count unless we do the mousePos thing we did after
            //if we're shooting at the mouse, our shoot direction should be mousePos - my transform.position
            Vector3 shootDir = mousePos - transform.position;
            //we fix the length of the shootDir to always have a length of 1
            shootDir.Normalize();
            //push the bullet in the shootDir direction, similar to the player movement script
            shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir;
            //CHALLENGE:
            //make it so the bullets go faster, but still maintain a consistent velocity
            //Try to get Enemy Health that will reduce when hit by a bullet
            shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * BulletSpeed;
            shotText.text = "Shots: " + ShotCount;
            Debug.Log("you have " + ShotCount + " shots left!");
        }
        else
        {
            shotText.text = "Shots: " + ShotCount;
        }
    }
    public GameObject ammoPack;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ammoPack") && ShotCount <= 200)
        {
            ShotCount += 10;
            //you're destroying the ammo pack prefab, not the one you hit
            //you need to destroy the object you collide with
            
            shotText.text = "shots: " + ShotCount;
        }

    }
}
