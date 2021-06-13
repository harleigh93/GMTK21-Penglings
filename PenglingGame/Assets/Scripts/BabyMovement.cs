using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyMovement : MonoBehaviour
{
    private GameObject player;
    private Vector3 playerPos;
    private Vector3 velocity;

    public float speed = 1;
    public float followDistance = 1;
    public float gravity = -1;

    public GameObject model;
    public UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {

        player = GameObject.Find("Player");
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        playerPos = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
        agent.destination = playerPos;
    }
}
