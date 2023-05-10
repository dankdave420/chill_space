using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Cam_LookAround : MonoBehaviour
{
    float rotationX = 0;
    float rotationY = 0;

    public float sensitivity = 1f;
    void Start()
    {
        Cursor.visible = false;
    }
    private void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * sensitivity * -1;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
