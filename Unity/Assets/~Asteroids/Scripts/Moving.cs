using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Clean code: CTRL + K + D (in that order)
// Fold code: CTRL + M + O
// Un-Fold code: CTRL + M + P

// Level 1 - Classes
// Level 2 - Functions and Variables
// Level 3 - Statements


namespace Asteroids
{

    public class Moving : MonoBehaviour
    {
        public float rotationSpeed = 360f;
        public float movementSpeed = 10f;

        // Use this for initialization
        void Start()
        {
            // Instructions (Statements) go here
        }

        void Rotation()
        {
            // Check if left is pressed
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                // Rotate left
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
            }
        }

        void Movement()
        {
            // Check if up key is pressed
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //Vector3 position = transform.position;
                //position.y += movementSpeed * Time.deltaTime;
                //transform.position = position;
                transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
            }

        }
        // Update is called once per frame
        void Update()
        {
            // Call 'Movement()' function
            Movement();
            // Call 'Rotation()' function
            Rotation();
        }

    }
}