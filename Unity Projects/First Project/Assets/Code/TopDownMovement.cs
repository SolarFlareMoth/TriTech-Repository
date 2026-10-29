using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Runtime.CompilerServices;

public class TopDownMovement : MonoBehaviour
{
    //o no, all gone!
    //first we need to ge the user "unput" (input)
    //then we need to push the player in the direction of the input
    public float moveSpeed = 10f;
    //create a second variable for a temporary ____ (any # value)
    public float dashSpeed = 50f;
    //use something called "coroutine",
    private bool isBoostActive = false;
    public void OnMove(InputValue value)
    { 
        //ooooooooooo words :D
        //has to bo OnMove
        //On is a secret keyword
        //Go look for "move" in unity
        //OnMove, OnLook,OnInteraction, etc.
        //Vector2 is a special variable meant to store 2 floats (x, y)
        //Vector3 is (x, y, z)
        Vector2 moveDir = value.Get<Vector2>();
        //holy cow
        //now that the cow priest is gone, damn, thats a lot of words. 
        //Thats Unity code.
        //If W is pressed, Vector2 = (0, 1) A = (-1, 0) S(0,-1)D(1,0)
        //use RigidBody in unity and a collider
        GetComponent<Rigidbody2D>().linearVelocity = moveDir * moveSpeed;
        //angleVelocity for rotational speed
        
    }
    //input method
    public void OnDash()
    {

        //Ok, time to attempt to make this ability do a "dodge" (move player in a burst), even though it's called dash
        //Update, put it in here so i can use the moveSpeed value without messing anything up

        //Only start timer if it isn't already running
        if(!isBoostActive)
        {
            StartCoroutine(TemporaryVariableTimer(1.0f)); //5 seconds duration, it worked!
        }
    }
    //The Coroutine that handles the temporary duration, what any of it means? I'm not sure at all :\
    private IEnumerator TemporaryVariableTimer(float duration)
    {
        //this starts it if the... IEnumerator (?) is activated in the code above
        isBoostActive = true;
        //save original speed
        float originalSpeed = moveSpeed;
        moveSpeed = dashSpeed;
        Debug.Log("The timer started!");

        //wait for the specified time
        yield return new WaitForSeconds(duration);

        moveSpeed = originalSpeed;
        isBoostActive = false;
        Debug.Log("It has stopped!");
    }
    //I just realized, I didn't get to make a jump, and double jump is an item on the ability system list
    //WELL WE ARE GOING INTO THIS BLIND, but he did say "yet"
}
