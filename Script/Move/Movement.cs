using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 20.0f;
    public float RotationSpeed = 40.0f;

    Rigidbody rb;
    Animator animator;
    BoxCollider boxCollider;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        boxCollider = gameObject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float y = Input.GetAxis("Horizontal") * RotationSpeed * Time.deltaTime;
        //print("Horiz" + Input.GetAxis("Horizontal"));
        transform.Translate(z, 0, 0, Space.Self);
        transform.Rotate(0, y, 0);


        animator.SetBool("IsIdle", Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0);
    }
}