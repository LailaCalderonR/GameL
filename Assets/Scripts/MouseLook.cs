using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensibility = 100f;
    public Transform playerBody;

    private float _xRotation;
   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensibility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensibility * Time.deltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        
        playerBody.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
    }
}
