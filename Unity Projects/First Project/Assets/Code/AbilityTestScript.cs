using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class AbilityTestScript : MonoBehaviour
{
    float timer = 0;
    public float FireballSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 5;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }
    public GameObject Fireball;
    //I CAST FIREBALL (pulls out a small drink labeled fireball)
    //okie time to do a "fireball", that means copying playerAttack's code :D
    public void OnAbility()
    {
        //Ok, I'm gonna have an "ability list", hence why it's OnAbility and not OnFireball, however the control doesn't exist yet, let's change that :D
        Debug.Log("the input is working");
        if(Time.timeScale >= 1 && timer >= 5)
        {
            Debug.Log("it's reading this");
            GameObject shot = Instantiate(Fireball, transform.position, Quaternion.identity);
            Destroy(shot, 10);
            Vector3 mousePos = Mouse.current.position.ReadValue();
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            Debug.Log(mousePos);
            Vector3 shootDir = mousePos - transform.position;
            shootDir.Normalize();
            shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir;
            shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * FireballSpeed;

            //alright, we got a shot that moves further, enemy code will have to be added onto for damage, but we will need to code here for cooldown, which means another timer system, thankfully I don't have to deal with learning that again :D
            //ope, almost 1:00, gonna do a drill then we get back to this
            timer = 0;
            Debug.Log("it is running!");
        }
           
    }

    //note to self, make a blast radius for fireball
}
