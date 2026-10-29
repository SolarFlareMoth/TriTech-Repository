using UnityEngine;
using UnityEngine.Analytics;

public class CustomFunctions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LevelUp();
    }

    // Update is called once per frame
    void Update()
    {
        LevelUp();
    }

    //variables defined at the class level can be used elsewhere
    public int xp = 1000;
    public int level = 1;
    void LevelUp()
    {
        //when we level up, we increase the player level if xp is high enough, then reduce xp
        //two variables we really care about: XP and level (maybe: cap, stats, etc.)
        //iteration: repeated action
        if (xp >= 100)
        {
            //when I level up, gain a level and subtract xp required to level from xp
            level = level + 1;
            //level += 1;
            //level++;
            xp -= 100;
            Debug.Log("Level up!");
        } 
    }
}
