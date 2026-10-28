using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Runtime.CompilerServices;

public class TopDownmovement : MonoBehaviour
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
        Vector2 moveDir = value.Get<Vector2>();
        GetComponent<Rigidbody2D>().linearVelocity = moveDir * moveSpeed;
    }
}
