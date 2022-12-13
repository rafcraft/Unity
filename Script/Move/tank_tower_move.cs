using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_tower_move : MonoBehaviour
{
    public Transform Canon;

    public float RotationSpeed = 10.0f;
    public Transform cam;
    private float yaw = 0;
    private float pitch = 0;

    void Update()
    {
            yaw += RotationSpeed * Input.GetAxis("Mouse X");
            transform.eulerAngles = new Vector3(0, yaw, 0);
            cam.eulerAngles = new Vector3(0, yaw, 0);
        yaw -= (int)(yaw / 360)*360;
        if (yaw < -180)
        {
            yaw = 360 + yaw;
        }

        if (yaw > 180)
        {
            yaw = -(360 - yaw);
        }

        pitch -= RotationSpeed * -Input.GetAxis("Mouse Y")/4;
        if (yaw >= 118 || yaw <= -118)
        {
            pitch = Mathf.Clamp(pitch, 0, 10);
        }
        else
        {
            pitch = Mathf.Clamp(pitch, -10, 10);
        }
        Canon.eulerAngles = new Vector3(0, yaw, pitch);
    }
}