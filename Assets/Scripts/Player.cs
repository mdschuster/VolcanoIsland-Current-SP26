using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float speed;
    public int health;
    private Rigidbody2D rb;
    private Vector2 input;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        input=value.Get<Vector2>();
        print(input);
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(input.x * speed, rb.linearVelocity.y);
        rb.linearVelocity = movement;
    }

}
