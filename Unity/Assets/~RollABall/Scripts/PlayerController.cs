using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RollABall
{
    public class PlayerController : MonoBehaviour
    {

        public float speed;

        private Rigidbody rb;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }


        //fixed update is for physics
        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

            rb.AddForce (movement * speed);
        }

        void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }

    }
}