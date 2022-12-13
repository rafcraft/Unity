using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_rotate : MonoBehaviour
{
    public float rotationSpeed_movementSpeed = 200.0f;

    void Update()
    {
        transform.Rotate(0, (-Input.GetAxis("Vertical") + Input.GetAxis("Horizontal")) * Time.deltaTime * rotationSpeed_movementSpeed, 0);
    }
}