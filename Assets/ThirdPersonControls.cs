using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ThirdPersonControls : MonoBehaviour
{

    public Rigidbody player;
    float movementSpeed = 10;
    public float horizontalSpeed = 2;
    public float verticalSpeed = 5;
    float jumpForce = 4000;
    float runSpeed = 12;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Mouse controls (only horizontal)

        float mouseXInput = Input.GetAxis("Mouse X") * horizontalSpeed;
        Vector3 lookhereX = new Vector3(0, mouseXInput, 0);
        transform.Rotate(lookhereX);

      



        //Keyboard controls
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.forward * Time.deltaTime * runSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.AddForce(0, jumpForce, 0);
        }
        if (Input.GetKey("w"))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey("s"))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey("a"))
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed;
        }

        if (Input.GetKey("d"))
        {
            transform.position += transform.right * Time.deltaTime * movementSpeed;
        }




    }

}
