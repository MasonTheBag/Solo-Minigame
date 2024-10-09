using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 12.0f;
    public float horizontalInput;
    public float verticalInput;
    private float xRange = 19.0f;
    private float zRange = 9.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Set boundaries for player 

        if (transform.position.x < -xRange)
        {

            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        else if (transform.position.x > xRange)
        {

            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }
        else if (transform.position.z < -zRange)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);

        }
        else if (transform.position.z > zRange)
        {

            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);

        }


        // Sets player movement when keys are pressed


        horizontalInput = Input.GetAxis("Horizontal");

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

    }
}
