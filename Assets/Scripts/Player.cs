using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float speed;
    public int maxHealth;
    private int currentHealth;
    private Rigidbody2D rb;
    private Vector2 input;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth=maxHealth;
        rb=GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        input=value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(input.x * speed, rb.linearVelocity.y);
        rb.linearVelocity = movement;
    }

    public void reset()
    {
        Vector3 pos = new Vector3(0, -3.9f, 0);
        transform.position = pos;
        currentHealth=maxHealth;
        this.gameObject.SetActive(true);
    }

    public void takeDamage(int damage)
    {
        currentHealth-=damage;
        if(currentHealth<=0)
        {
            //play a sound
            //play a particle effect
            //display gameover UI
            this.gameObject.SetActive(false);
        }
    }
    
}
