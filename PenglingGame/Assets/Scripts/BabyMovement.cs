using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMovement : MonoBehaviour
{
    public CharacterController controller;

    private GameObject player;
    private Vector3 playerPos;
    private Vector3 velocity;

    public float speed = 1;
    public float followDistance = 1;
    public float gravity = -1;

    public GameObject model;

    void Start()
    {

        player = GameObject.Find("Player");
    }

    void Update()
    {
        playerPos = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        //playerPos = new Vector3(player.position); (this didn't work)

        float distanceToPlayer = Vector3.Distance(playerPos, transform.position);
        if(distanceToPlayer >= followDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);

            model.transform.LookAt(player.transform);
        }
        

        velocity.y += gravity * Time.deltaTime;

        if (controller.isGrounded)
        {
            velocity.y = 0;
        }
        else
        controller.Move(velocity * Time.deltaTime);
    }
}
