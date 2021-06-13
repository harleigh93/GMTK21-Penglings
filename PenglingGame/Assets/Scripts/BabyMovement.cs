using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMovement : MonoBehaviour
{
    private GameObject player;
    private Vector3 playerPos;
    private Vector3 velocity;
    public Rigidbody rb;

    public float speed = 2;
    public float followDistance = 1;


    public GameObject model;


    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        playerPos = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
    }

    void FixedUpdate()
    {

        if (Vector3.Distance(transform.position, playerPos) > followDistance)
        {
            transform.LookAt(playerPos);
            rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);
        }

        if (rb.velocity.magnitude > 3)
        {
            rb.velocity = rb.velocity.normalized * 3;
        }
    }

}