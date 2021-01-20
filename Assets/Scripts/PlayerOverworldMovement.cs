using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverworldMovement : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public Rigidbody2D RB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movement;
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        RB.MovePosition(RB.position + movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
