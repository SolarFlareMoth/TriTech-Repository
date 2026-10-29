using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

//Code line below "adds the component if its not already on the object"
[RequireComponent(typeof(Rigidbody2D))]
public class TestingScript1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Hi! welcome to Nick's testing script, I'm called "Ace"
        //Nick likes calling stuff "Ace" a lot, if it's important
        //Don't use this as code, use as a... guide of sorts!
        int health = 5;
        string name = "Ace";
        Debug.Log(name + ": Hello World! I work! and I have " + health + " HP left");
        //let's try some other commands!
        int randomnum;
        randomnum = Random.Range(1, 101);
        Debug.Log(name + " is thinking of the number: " + randomnum);
        //Looks like randomnumb is working!
        //lets make it detect if the number is above or below 50!
        if (randomnum >= 50)
        {
            Debug.Log("The number is above or equal to 50!");
        }
        if (randomnum < 50)
        {
            Debug.Log("the number is under 50!");
        }
        //let's make a leveling system!
        //Go to void Leveling!
        Leveling();
        //that took a little bit
        Debug.Log("Level " + lvl);
        //only says starting level, idk how to make it actually update every time it updates
        //I also made my character do the squished putin walk from that one old meme of him walking down a hallway... why is that a meme again?
        //cuz titanic i think
        //how is titanic related to putin walking down a hallway?


        //Color Code in a webite is using Hexidecimal
        //FF = max
        //1-9 then A-F then 10 = 16
        //left digit to normal binary is 128,64,32,16, right is 8,4,2,1, which can convert to hexidecimal kinda ez
        //AA/FF/CC is Red/Green/Blue, example: FF22AA would be 255R 22G 110B, so a dark redish-purple.

        //so loading screens exist because they have to "build" the world when you load them or die.
        //online games dont have this but they are more "code intensive" (intensive code-wise)
        //I remember playing fable 3 and they didn't really do the whole load screen thing, it just kinda faded to black then started you at the last entryway you came from? I could be wrong

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
            //at least one of these is true, and so the code RUNS
            //HOORAY!!!!
            //also called a logic gate
            //closed || closed || open || closed
            // it is opened
        }
        if (false && true || false && false || true && false || true && true)
        {
            //does this code run? YES/ Why??                       this^^^^ 
        }
        if (false || true && !false)
        {
            //does this code run, YES. ! means not!!!
        }

        bool isAlive = true;
        //is it legal to do this?
        if (isAlive == true)
        {
            //technically yes, it's just very bad programming
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
        if (hasCake || eggs > 0 && hasOil && hasBoxMix || hasMoney)
        {
            //i get to eat cake!!!
        }
        else
        {
            //I eat a cookie
            //else code only runs if the IF condition is false, and the if code doesn't run
        }
        //above is foundational for most other code, all IF statements use this

        //code below is how to use a "ternary conditional operator,
        int time = 20;

        // Traditional if-else structure
#pragma warning disable CS0219 // Variable is assigned but its value is never used
        string result1;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
        if (time < 18)
        {
            result1 = "Good day.";
        }
        else
        {
            result1 = "Good evening.";
        }

        // Equivalent shorthand using the ternary operator
        string result2 = (time < 18) ? "Good day." : "Good evening.";

        //ok this makes a lot of sense!


    }
    public int xp;
    public int lvl;
    // Update is called once per frame
    void Update()
    {
        Leveling();
    }
    //So much wasted space between lines
    void Leveling()
    {
        //lvl = 0;
        //xp = 100;
        if (xp >= 50)
        {
            lvl++;
            xp -= 50;
            Debug.Log(" Your Level " + lvl);
        }
    }
    public int MoveSpeed = 3;
    public void OnMove(InputValue value)
    {
        Vector2 MoveDir = value.Get<Vector2>();
        GetComponent<Rigidbody2D>().linearVelocity = MoveDir * MoveSpeed;
        //line above has a grey bar next to the wheel on the right?
        //we got movement!
        //remember! If W is pressed, Vector2 = (0, 1) and A = (-1, 0) S = (0,-1) D = (1,0) like a coordinate plane.
    }
    //this meant if you bonk into something you will activate this code
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
            if (health <= 0)
            {
                Debug.Log("haha, im in danger -Ralphie Wiggums");
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public int health = 100;
    public GameObject healthPack;

    //in unity when you make something a trigger, you can pass through the object but you gotta just slightly change its code a shown below
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("healthPack") && health <= 199)
            //THIS FINALLY WORKED!!!! TY ALTA!!
        {
            health += 10;
            Destroy(healthPack);
            Debug.Log("health up!");
            //this allows a healthpack to restore health, i put the deletion of said healthpack in its own code, as shown below (there's almost definitly a better way to do this but unity does't allow it)
            // private void OnTriggerEnter2D(Collider2D collision)
            //{
            //if (collision.gameObject.CompareTag("Player"))
            //{
            //  Destroy(gameObject);
            //}
            //}
        }
    }
    //means when you enter collision, this code runs, I'm not doing that here, it would make everything a pain to make sure it runs right
    //OnCollisionStay means every frame you're inside, and OnCollisionExit is upon exiting the collision. Make sure it says  2D for 2D games otherwise it doesn't like that.
    //i want us to go into 3D
    //I also need to improve my typing speed with P's, I really suck at P (I accidentally made that a {)

    //to make randomly generated areas you would put what's below

    /*
    void createWalls()
    {
    int wallCount = Mathf.Max(1, (int)(roomSize.x / wallSize.x));
    float scale = (roomSize.x / wallCount) / wallSize.x;
    for (int i = -; i < wallCount; i++)
    {
    var position = transform.position + new Vector3(-roomSize.x / 2 + wallSize.x * scale / 2 + i * scale * wallSize.x, 0, -roomSize.y / 2);
    var s = new Vector3(scale, 1, 1);
    //Mx-Px, My-Py or M-P or destination - start M=mouse P=player
    }
    } */

    //this list is getting long
    //finding out how to do menu things, this is kinda mostly unity though.
    //Canvas goes into the button code for what the button is for, select code from the code we create, then a function we made (a void)

    //we can use the symbol && to combine two different conditions

    //hold alt and use arrows to move lines!

    //! = / != (not equal)

    //ooooooooooo words :D
    //has to bo OnMove
    //On is a secret keyword
    //Go look for "move" in unity
    //OnMove, OnLook,OnInteraction, etc.
    //Vector2 is a special variable meant to store 2 floats (x, y)
    //Vector3 is (x, y, z)
    // Vector2 moveDir = value.Get<Vector2>();
    //Thats Unity code.
    //If W is pressed, Vector2 = (0, 1) A = (-1, 0) S(0,-1)D(1,0)
    //use RigidBody in unity and a collider
    // GetComponent<Rigidbody2D>().linearVelocity = moveDir* moveSpeed;
    //angleVelocity for rotational speed

    //doing anything with menu bottons means make a main code for the entire ui with new voids for each button and what they do 

    //ternary conditional operators
    //conditional means... what... it means... under a specific... something... then it can happen, or maybe it's the "condition" of something, how well it is...
    //operator usually means action, "if this happens, then do this"... what does ternary mean?
    // it's a "?:" 
    //condition? expression_if_true : expression_if_false;
    //a boolean, if, else
    //condition, ?, :
    //how i would use that? not a clue
    //line 143 is when I looked it up and then put the example that was given
    //nothing was written in order btw, it's kinda everywhere right now

    // New stuff below! use as a guide for temporary values! it's also on the TopDownMovement script!
    //input method
    /*public void OnDash()
    {

    //Ok, time to attempt to make this ability do a "dodge" (move player in a burst), even though it's called dash
    //Update, put it in here so i can use the moveSpeed value without messing anything up

    //Only start timer if it isn't already running
      if (!isBoostActive)
      {
    StartCoroutine(TemporaryVariableTimer(1.0f)); //5 seconds duration, it didn't work... um...
    }
    }
    The Coroutine that handles the temporary duration, what any of it means? I'm not sure at all :\
    private IEnumerator TemporaryVariableTimer(float duration)
    {
    this starts it if the... IEnumerator (?) is activated in the code above
    isBoostActive = true;
    save original speed
    float originalSpeed = moveSpeed;
    moveSpeed = dashSpeed;
    Debug.Log("The timer started!");

    wait for the specified time
    yield return new WaitForSeconds(duration);

    moveSpeed = originalSpeed;
    isBoostActive = false;
    Debug.Log("It has stopped!");
    } */
    
    // Show radius in unity

    public class RadiusVisualizer : MonoBehaviour
    {
        public float radius = 5f;
        public Color gizmoColor = Color.green;//indicates colour

        private void OnDrawGizmos()
        {
            Gizmos.color = gizmoColor;
            // Draws a wireframe sphere around the object's position
            Gizmos.DrawWireSphere(transform.position, radius);
        }
    }
    // end of line


    //Fixed update, Upadates at a specific time interval pace, independant of framerate
    void FixedUpdate()
    {
        //what number of times does this run ber second? i dunno -\( `^')/-
    }

}
