using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverworldMovement : MonoBehaviour
{
    private float MoveSpeed = 5f;

    private Rigidbody2D RB;

    private CameraFollow camera;

    // Start is called before the first frame update
    void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();
        camera = FindObjectOfType<CameraFollow>();
        camera.SetTarget(transform);
        camera.SetOffset(new Vector3(0, 0, -10));
        camera.SetSmoothingFactor(8.5f);
        
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
