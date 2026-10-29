using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float BulletSpeed = 2f;
    public GameObject enemyBullet;

    // Update is called once per frame
    void Update()
    {
        
    }

    //for this we might need FixedUpdate (meaning a specific time interval, independant of framerate), speaking of framerate
    //Scott Cawthon coulda used this for fozy in FNAF 1, to prevent speedrunners from using my home PC for speedruns on FNAF 1 to cheat everyone, since animatronics except foxy
    //could only start moving after you open your camera. Opening it stalls Foxy when you stare at him. 
    //Funny how much i know about coding FNAF but not ANYTHING ELSE before this class lol.

    //Fixed update, Upadates at a specific time interval pace, independant of framerate
    void FixedUpdate()
    {
        //what number of times does this run ber second? i dunno -\( `^')/-
    }
}
