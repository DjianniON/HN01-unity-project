using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{
    private Rigidbody rb;
    private float movementSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
  
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Mouse X");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Mouse Y");
        float JumpImput = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(horizontalInput, JumpImput, verticalInput);

        rb.AddForce(movement * movementSpeed);
        transform.Rotate(verticalInput, horizontalInput, JumpImput, Space.Self);
    }
}