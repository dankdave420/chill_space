using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    void Update()
    {
        Vector3 inputDirection = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W)) inputDirection.z = +1f;
        if (Input.GetKey(KeyCode.S)) inputDirection.z = -1f;
        if (Input.GetKey(KeyCode.A)) inputDirection.x = -1f;
        if (Input.GetKey(KeyCode.D)) inputDirection.x = +1f;

        Vector3 moveDirection = transform.forward * inputDirection.z + transform.right * inputDirection.x;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
