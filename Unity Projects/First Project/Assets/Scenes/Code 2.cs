using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //if statements check to see if a value is true or false
        //if the value is true, the contained code is executed
        //if the value is false, the code is skipped
        if (false)
        {
            //this code will be run if the condition is true
            Debug.Log("this code is running!");
        }
        int health = 0;

        if (health > 0)
        {
            Debug.Log("I'm alive!!");
        }
        //Example above
        //Red ~ will appear if it detects a problem!
        if(health <= 0)
        {
            Debug.Log("You Died! your now a ghost! just make sure your parents arent ghost hunters! (Danny's a phantom)");

        }
        //most basic form of Conditional statements above

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
