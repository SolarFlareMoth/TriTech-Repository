using UnityEngine;

public class IsItEnoughassignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Hi! 
        int score;
        score = 54;
        if (score >= 100)
        {
            Debug.Log("Reward Unlocked!.");
        }
        if (score <= 100)
        {
            Debug.Log("Keep Playing!");
        }
        //this was quick!
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
