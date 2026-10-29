using JetBrains.Annotations;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //any time we are looping through something, it can be heavy in processing
        //"for loop" is the most common form of looping through repeated behavior
        //as an exampler: loop through all enemies, shoot at nearest one
        //anatomy of a "for loop": first has a starting variable, then break condition,
        //finally an operation happens each loop
        //starting at 0 and as long as i is less than 10, loop through and increase i by 1
        //boolean
        for(int i = 0; i <= 10; i++)
        {
            //Debug.Log(i);
        }
        //this will add up all the numbers from 1 to 100
        int number = 0;
        for (int i = 1; i < 100; i++)
        {
            number += i;
        }
        //number is the sum of all numbers up to 100
        //Debug.Log("number = " + number);
        //sacred ground for programmers


        //i want to know the locations of all enemies in the level
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        //this one s means find ALL, not just one
        //[] means its an array of the variable (in this case, game objects)
        //we can have arrays of different variables, like its, floats, etc
        //an array is a collection of variables of the same type
        // int his case, the type is gameobjec, all of which are tagged an enemy in the scene
        //array of ints = [5, 17, -25, 104, 0] 
        //ILLEGAL [7, 17.3, Bob, false]
        //int[] nums;
        //nums[0] = 5

        for(int i = 0; i < enemies.Length; i++)
        {
            //Length is the number of variables stored in the array
            //as long as I is less than the number of variables in the array
            //this code will continue to run
            Debug.Log(enemies[i].transform.position);
            //this is where magic happens, what happens if i only have 1 enemy? 
            //only once, because [i] means 0 on first running
        }
        int h = 0;
        for (int c = 17; c <= 192; c++)
        {
            h += c;
            Debug.Log(h);
            //I got 18392
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        //MY FRAAAAAAAAAAAAAAAAAAAA-
        //THANK YOU
        //if you put two loops with 100 with 2 seperate variables it runs 10000 TIMES PER FRAME

        /*for (int i = 0; i < 100; i++)
          {
               for (int j = 0; j < 100; j++)
               {
                   //this code runs 10K times a frame
               }
          }
          */
    }

    //CHALLENGE: Create a for loop to add up all the nmbers from 17 to 192
}
