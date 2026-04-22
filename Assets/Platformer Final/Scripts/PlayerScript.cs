using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class PlayerScript : MonoBehaviour
{


    //I like to make variables for all my components even
    //if I'm not sure if I'll use them in code
    public SpriteRenderer SR;
    public Rigidbody2D RB;
    public Collider2D Coll;
    public ParticleSystem PS;
    public AudioSource AS;
    public GameObject GO;

    //My personal stats
    public float Speed = 5;
    public float JumpPower = 10;
    public float Gravity = 3;

    //Variables I use to track my state
    public List<GameObject> Touching;
    public bool OnGround = false;
    

    //My Sound Effects
    public AudioClip JumpSFX;

    //List Stuff

    public List<SpriteRenderer> SRs;

    void Start()
    {
        //Set our rigidbody's gravity to match our stats 
        RB.gravityScale = Gravity;
    }

    void Update()
    {
        
        //movement tracking
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

        //Pressing Space Jumps
        if (Input.GetKeyDown(KeyCode.Space) && CanJump())
        {
            vel.y = JumpPower;
          
        }

        //Here I actually feed the Rigidbody the movement I want
        RB.linearVelocity = vel;
        


    }

    //jump tracking (currently not working right)
    public bool CanJump()
    {
        return Touching.Count > 0;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //If I collide with something solid, mark me as being on the ground
        OnGround = true;
        if (!Touching.Contains(other.gameObject))
            Touching.Add(other.gameObject);

        
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        //If I stop touching something solid, mark me as not being on the ground
        OnGround = false;
        Touching.Remove(other.gameObject);
    }
}
