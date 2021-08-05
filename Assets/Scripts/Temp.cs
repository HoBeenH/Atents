using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody playerRigidbody;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");

        float moveZ = Input.GetAxis("Vertical");

        float jump = Input.GetAxis("Jump");

        //float fall = jump;

        //Vector3 Cube = transform.position;
        //Cube.x = Cube.x + moveX * Time.deltaTime * speed;
        //Cube.y = Cube.y + jump * Time.deltaTime * speed;
        //Cube.z = Cube.z + moveZ * Time.deltaTime * speed;

        //transform.position = Cube;

        Vector3 velocity = playerRigidbody.velocity;
        velocity.x = velocity.x + moveX * speed;
        velocity.y = velocity.y + jump * speed;
        velocity.z = velocity.z + moveZ * speed;
        playerRigidbody.velocity = velocity;
        



    }
}