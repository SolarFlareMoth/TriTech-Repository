using JetBrains.Annotations;
using UnityEngine;

public class BoolCOnditions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //the most basic if statements
        if (true)
        {
            //this code will always run
        }
        if (false)
        {
            //this code will never run
        }
        if (true && true)
        {
            //true and true is true, so this will run
            //  && as an operation means all conditions must be true to run
            //you have lock picks, and the skill to pick locks
        }
        if (true && false)
        {
            //true && false, at least one cond is false, so this code doesn't run
            //you have lock picks, but not the skill to pick the lock
        }
        if (true || false)
        {
            //true OR false, at least one of these conditions is true, so this code runs
            //either i have the key to open the door, or i use my strength to open it
        }
        if (true && false || true && true && false || true && true && true || false)
        {
            //START PANICKING!!!
            //this is the reality of coding, this cna happen, commonly
            //first, break it down into each OR section, and figure out if true, or false
            //false || false || true || false
            //at least one of these is truem so the code RUNS
            //HOORAY!!!!
            //sometimes called a logic gate
            //closed || closed || open || closed
            // it is opened
        }
        if (false && true || false && false || true && false || true && true)
        {
            //does this cod erun? YES/ Why??                       this^^^^ 
        }
        if(false || true && !false)
        {
            //does this code run, YES. ! means not!!!
        }

        bool isAlive = true;
        //is it legal to do this?
        if(isAlive == true)
        {
            //technically yes, very bad programming
            //instead do this:
            if (isAlive)
            {
                //this is the same thing, but shorter and better
                //we will lose points if we do this
            }
        }
        bool hasCake = false;
        int eggs = 1;
        bool hasOil = true;
        bool hasBoxMix = true;
        bool hasMoney = false;
        if(hasCake||eggs >0 && hasOil && hasBoxMix || hasMoney)
        {
            //i get to eat cake!!!
        }
        else
        {
            //I eat a cookie
            //else code only runs if the IF condition is false, and the if code doesn't run
        }
        //above is foundational for most other stuff
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
