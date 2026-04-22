using NUnit.Framework;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //components
    public SpriteRenderer SR;
    public Rigidbody2D RB;
    public Collider2D Coll;
    public ParticleSystem PS;
    public AudioSource AS;
    public GameObject GO;

    //player stats
    public float Speed = 5;
    public float JumpPower = 10;
    public float Gravity = 3;


    void Start()
    {
        //Set our rigidbody's gravity to match our stats 
        RB.gravityScale = Gravity;
    }

    // Update is called once per frame
    void Update()
    {
        //I'll use this variable to track the movement I want
        //By default, I move like I moved last frame
        Vector2 vel = RB.linearVelocity;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //If I hit right, move right
            vel.x = Speed;
           
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //If I hit left, move right
            vel.x = -Speed;
            
        }
        else
        {  //If I hit neither, come to a stop
            vel.x = 0;
        }
    }
}
