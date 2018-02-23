using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GoneHome
{
    public class Player : MonoBehaviour
    {

        public float movementSpeed = 10f;

        private Rigidbody rigid;


        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            // Get input
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

            // Convert input to Vector3 direction
            Vector3 inputDir = new Vector3(inputH, 0, inputV);

            // Use direction to apply force... also with speed
            rigid.AddForce(inputDir * movementSpeed);

            // Copy position
            Vector3 position = transform.position;

            // Modify position
            position += inputDir * movementSpeed * Time.deltaTime;

            // Apply position to rigidbody (to test for collisions)
            rigid.MovePosition(position);
        }
    }
}