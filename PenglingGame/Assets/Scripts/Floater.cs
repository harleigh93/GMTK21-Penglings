using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    public Rigidbody rb;
    public float displacementAmount = 1;

    private GameObject water;

    void Start()
    {

        water = GameObject.Find("Water");
    }

    private void FixedUpdate()
    {
        float waterHeight = water.transform.position.y;
        if (transform.position.y < waterHeight)
        {
            Vector3 force = new Vector3(0, 6, 0);
            rb.AddForce(force);
        }
    }
}
