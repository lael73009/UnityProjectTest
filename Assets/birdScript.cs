using UnityEngine;
using System;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float flapStrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public logicScript logic;
    public bool birdIsAlive = true;
    public int health = 3;

    void Start()
    {
        health = 3;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicScript>();
    }

    // Update is called once per framedß
    void Update()
    {

        //Console.WriteLine("Processing Update");
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            rigidBody.linearVelocity = Vector2.up * flapStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        logic.changeHealth(health);

        if (health <= 0)
        {
            logic.gameOver();
            birdIsAlive = false;
            logic.changeHealth(0);
        }
    }
}
