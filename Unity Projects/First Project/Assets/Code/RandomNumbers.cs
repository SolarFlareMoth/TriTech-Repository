using UnityEngine;
using UnityEngine.Rendering;

public class RandomNumbers : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //welcome into the world random numbers!
        int r = -1;

        r = Random.Range(1, 101);
        //Random.Range causes you to not be allowed to call it random or range
        //random.range for intigers is inclusive on the min,
        //exlusive on the max. So (1, 100) can give values from 1-99, NOT 100!!!
        Debug.Log(r);
        //this checks the randomly put value for "r"

        float rand = Random.Range(1f, 100f);
        //max is INCLUSIVE for floats
        //floats using Random.Range are inclusive on the min AND max
        //so (1f, 100f) can five and value from 1.0-100.0
        Debug.Log(rand);
        //if mt random float is high enough, get a special loot drop
        //Yay, teaching gambling lol
        if(r > 50)
        {
            Debug.Log("you recieved Cheeseburger's Salmon! Give it to Cheeseburger to add the bear as a pet!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
