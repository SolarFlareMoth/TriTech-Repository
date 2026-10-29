using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //This is a code comment! forward slashes!
        //Debug is a class that someone else wrote!
        //Debug has a function Named Log!
        //Log recieves any variables in the () and spits it out to the console!
        //the end of this line has a ; which marks the end of a single line of code!
        Debug.Log("Hello World!");

        //This is called variable declaration. We create a new variable
        //first we say what type of variable it is, then we name it and seat it to a value
        int health = 10;
        //after we declare health, we don't need to say its type anymore whern we refer to it
        health = 9;
        //we can also do mathematical operations using ints
        health = 10 - 1;
        //we can also use the variable in mathematical operations
        health = health - 1;
        //Intigers are whole numbers
        //floats srore decimal values, rounded to a number of decimals, end in f
        float critChance = 0.1f;
        //Yay, I wrote code!
        //Unity doesnt like Pi, so it becomes 3.14159
        //If its a gps cord, don't use floats, noted
        //any operation we can do to an int, we can also do to a float
        critChance = critChance + 0.1f;
        //names are case sensitive!!! Important to know!!!
        //strings hold a string (or collection) of characters, making words
        //"Hello world!" far above is a string
        string name = "Jeff";
        //we can also add strings together!
        Debug.Log("hello " + name);
        //the output from this code will be "Hello John"
        //Bools store a true or false value, used in lots of logic checks
        bool hasKey = true;
        bool isDead = false;
        //name stuff appropreatly
        //Yay! I can code now!

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
