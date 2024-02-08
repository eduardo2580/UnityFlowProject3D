using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    
    public Transform targetObject;
    public float mouseSensitivity = 0.8f;
    public float heightAboveTarget = 2.0f; // Adjust this value based on your needs
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotate the target object based on mouse movement
        targetObject.Rotate(Vector3.up * mouseX * mouseSensitivity, Space.World);
        targetObject.Rotate(Vector3.right * mouseY * mouseSensitivity, Space.Self);

        // Set the camera position at a fixed height above the target object
        Vector3 desiredPosition = targetObject.position - targetObject.forward * 5.0f + Vector3.up * heightAboveTarget;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 5.0f);
    }
}
