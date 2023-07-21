using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidbody;
    public float flyHeight;
    public bool alive;
    public LogicScript logic;
    public AudioSource AudioJump;
    void Start()
    {
        alive = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) == true && alive==true)
        {
            AudioJump.Play();
            myRigidbody.velocity=Vector2.up*flyHeight;
        }

        if (transform.position.y<=-9)
        {
            logic.GameOver();
            alive = false;
        }

        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer!=7)
        {
            logic.GameOver();
            alive = false;
        }
    }
}
