using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player4DirectionalMovement : MonoBehaviour
{
    public float moveSpeed = 0.2f;
    public Rigidbody rb;
    public Animator animator;
    public AudioSource jumpSound;

    Vector3 savedDirection;
    float currentSpeed = 0;

    public GameObject model;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public float jumpForce = 2.0f;
    public bool isGrounded;

    public void Start()
    {
        rb.maxAngularVelocity = 1;
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3 (1,0,0) * moveSpeed * Time.fixedDeltaTime);
            savedDirection.x = 1;
            savedDirection.z = 0;
            currentSpeed = 1;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.fixedDeltaTime);
            savedDirection.x = -1;
            savedDirection.z = 0;
            currentSpeed = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, 0, -1) * moveSpeed * Time.fixedDeltaTime);
            savedDirection.x = 0;
            savedDirection.z = -1;
            currentSpeed = 1;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 0, 1) * moveSpeed * Time.fixedDeltaTime);
            savedDirection.x = 0;
            savedDirection.z = 1;
            currentSpeed = 1;
        }
        else
        {
            currentSpeed = 0;
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0,1,0) * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            jumpSound.Play();
        }

        if (currentSpeed >= 0.1)
        {
            float targetAngle = Mathf.Atan2(savedDirection.x, savedDirection.z) * Mathf.Rad2Deg;
            model.transform.rotation = Quaternion.Euler(0, targetAngle, 0);
            //float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            // model.transform.rotation = Quaternion.Euler(0, angle, 0);
        }

        if (rb.velocity.magnitude > 3)
        {
            rb.velocity = rb.velocity.normalized * 3;
        }

        //animator.SetFloat("SavedHorizontal", savedDirection.x);
        //animator.SetFloat("SavedVertical", savedDirection.y);
        // animator.SetFloat("Speed", currentSpeed);
    }
}

