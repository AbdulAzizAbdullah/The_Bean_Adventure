using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
 public float MouseSensitivity = 350f;
 
 public Transform PlayerBody;   

 float xRotation = 0f;
    
    void start ()
    {
      Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f , 90f ); 

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);       
        PlayerBody.Rotate(Vector3.up * MouseX);
    }
    
}
