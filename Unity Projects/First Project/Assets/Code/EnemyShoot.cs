using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject Bullet;
    //how fast the bullets go
    public float bulletspeed = 5f;
    //delay between shots
    public float shootDelay = 3;
    //carrying my usual distance float
    public float shootDistance = 5;
    //referance to player
    GameObject player;
    //i need to know how much time has passed between shots, include time
    private float timer = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //every X seconds, we want to shoot at the player if the player is close
        //delta means change
        //deltaTime means change in time between frame updates
        //we are adding the slivers of time betweeen frames, to figure out how much total time is passed
        timer += Time.deltaTime;

        if (timer > shootDelay)
        {
            //shoot is off cooldown, shoot player (us)
            //Destination - starting position
            //out equasion for the vector from the enemy to the player is above
            //or in this case, players position - enemy position
            Vector3 shootDir = player.transform.position - transform.position;//don't get backwards!!!
            //magnitude of shootDir tells us how far the player is
            if (shootDir.magnitude < shootDistance)
            {
                //ITS MARKIPLIER, HE'S WITHIN 500 FEET OF A TIM HORTONS!! GET HIM!!
                GameObject shot = Instantiate(Bullet, transform.position, Quaternion.identity);
                shootDir.Normalize();
                //push the bullet in the shoot direction
                shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * bulletspeed;
                Destroy(shot, 10); //for some reason unity doesn't allow this to happen, I'm not happy
                timer = 0;

            }


        }


    }
}
