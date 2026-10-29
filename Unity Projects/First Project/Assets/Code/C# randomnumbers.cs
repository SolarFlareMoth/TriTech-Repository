using UnityEngine;

public class randomnumbersassignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Attack;
        string name = "Ace Wolfen";
        Attack = Random.Range(50, 500);
        if (Attack >= 50)
        {
            Debug.Log(name + " defeated a monster!");
        }
        if(Attack < 50)
        {
            Debug.Log(name + " Died To A Bear Named Cheeseburger, congrats :)");
        }

        int LootChance;
        Debug.Log(Attack);
        LootChance = Random.Range(1, 100);
        Debug.Log(LootChance);
        if (Attack >= 50)
        {
            if (LootChance <= 39)
            {
                Debug.Log(name + " got... a button coin?");
            }
            if (LootChance >= 40)
            {
                if (LootChance <= 69)
                {
                    Debug.Log(name + " got Pickle Rick!!!");
                }
            }
            if (LootChance >= 70)
            {
                if (LootChance <= 89)
                {
                    Debug.Log(name + " got a rare Mewtwo Fish");
                }
            }
            if (LootChance >= 90)
            {
                if (LootChance <= 100)
                {
                    Debug.Log(name + " got the legendary 'Made Their Own Fate' Trophy! Congrats Guardian");
                }
            }
        }



        //it would turn into this:
        int testing;
        testing = -5;
        if (testing <= 0 || testing >= -10)
        {
            Debug.Log("worked!");
        }
        else
        {
            Debug.Log("Nope!");
        }

        Debug.Log("Debug Logs will appear IN ORDER... I forgot this while testing");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
