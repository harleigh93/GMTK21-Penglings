using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPlatform : MonoBehaviour
{
    float originalY;

    public float floatStrength = 0.85f;
    public float speed = 1;

    void Start()
    {
        this.originalY = this.transform.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x,
            originalY + ((float)Mathf.Sin(Time.time) * floatStrength),
            transform.position.z);
        transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
    }
}
